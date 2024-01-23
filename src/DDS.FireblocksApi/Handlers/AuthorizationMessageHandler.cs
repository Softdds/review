using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Cryptography;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using DDS.FireblocksApi.Configuration;

namespace DDS.FireblocksApi.Handlers
{
    internal sealed class AuthorizationMessageHandler : DelegatingHandler
    {
        private static readonly Task<byte[]> NullResult = Task.FromResult(Array.Empty<byte>());

        private readonly ILogger<AuthorizationMessageHandler> _log;
        private readonly FireblocksSettings _config;
        private readonly RSA _rsa;
        private readonly SigningCredentials _creds;

        public AuthorizationMessageHandler(ILogger<AuthorizationMessageHandler> log, IOptions<FireblocksSettings> options)
        {
            _log = log;
            _config = options.Value;

            _rsa = RSA.Create();
            _rsa.ImportPkcs8PrivateKey(Convert.FromBase64String(_config.SecretKey), out _);
            _creds = new SigningCredentials(new RsaSecurityKey(_rsa), SecurityAlgorithms.RsaSha256)
            {
                CryptoProviderFactory = new CryptoProviderFactory
                {
                    CacheSignatureProviders = false
                }
            };
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var requestBody = await GetRequestBodyAsync(request, cancellationToken);

            var jwt = GenerateJwtToken(request.RequestUri.PathAndQuery, requestBody);
            request.Headers.Add("X-API-Key", _config.ApiKey);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

            return await base.SendAsync(request, cancellationToken);
        }

        private Task<byte[]> GetRequestBodyAsync(HttpRequestMessage request, CancellationToken ct)
        {
            if (request.Method == HttpMethod.Get
                || request.Method == HttpMethod.Delete
                || request.Method == HttpMethod.Head
                || request.Method == HttpMethod.Options
                || request.Method == HttpMethod.Trace
                || request.Content is null)
            {
                return NullResult;
            }

            if (request.Content is StringContent
                || request.Content is JsonContent
                || string.Equals(request.Content.Headers.ContentType?.MediaType, "application/json", StringComparison.InvariantCultureIgnoreCase)
                || string.Equals(request.Content.Headers.ContentType?.MediaType, "text/json", StringComparison.InvariantCultureIgnoreCase))
            {
                return request.Content.ReadAsByteArrayAsync(ct);
            }

            _log.LogWarning(
                "Unable to get request body for content with type '{contentType}' and mediaType '{mediaType}'",
                request.Content.GetType().Name,
                request.Content.Headers.ContentType?.MediaType ?? "<null>");

            return NullResult;
        }

        private string GenerateJwtToken(string pathAndQuery, byte[] body)
        {
            var payload = GetPayload(pathAndQuery, body);
            var token = new JwtSecurityToken(new JwtHeader(_creds), payload);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private JwtPayload GetPayload(string pathAndQuery, byte[] body)
        {
            var issuedTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var expirationTimestamp = issuedTimestamp + 60;

            return new JwtPayload
            {
                {"uri", pathAndQuery},
                {"nonce", DateTime.UtcNow.Ticks.ToString()},
                {"iat", issuedTimestamp},
                {"exp", expirationTimestamp},
                {"sub", _config.ApiKey},
                {"bodyHash", HashBody(body)}
            };
        }

        private static string HashBody(byte[] body)
        {
            using var sha256 = SHA256.Create();
            var hash = sha256.ComputeHash(body);
            return BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
        }

        protected override void Dispose(bool disposing)
        {
            _rsa.Dispose();

            base.Dispose(disposing);
        }
    }
}
