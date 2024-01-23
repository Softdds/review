using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web;
using DDS.Utils.Extensions;

namespace DDS.Core.Api
{
    public abstract class BaseApi
    {
        protected virtual MediaTypeHeaderValue RequestMediaType { get; } =
            MediaTypeHeaderValue.Parse("application/json");

        protected virtual JsonSerializerOptions SerializerOptions { get; } = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true,
            WriteIndented = false,
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
            Converters =
            {
                new JsonStringEnumConverter()
            },
        };

        private readonly HttpClient _http;

        public BaseApi(HttpClient http)
        {
            _http = http;
        }

        protected async Task<T> ExecuteRequestAsync<T>(
            string requestUri,
            HttpMethod method,
            object content = null,
            object queryParams = null,
            CancellationToken ct = default)
        {
            var request = new HttpRequestMessage(
                method,
                BuildUri(_http.BaseAddress, requestUri, ParseQueryParams(queryParams)));

            if (content is not null)
            {
                request.Content = new StringContent(
                    JsonSerializer.Serialize(content, SerializerOptions),
                    Encoding.UTF8);
                request.Content.Headers.ContentType = RequestMediaType;
            }

            using var response = await _http.SendAsync(request, ct);

            return await HandleResponseAsync<T>(response, ct);
        }

        protected virtual async Task<T> HandleResponseAsync<T>(HttpResponseMessage response, CancellationToken ct)
        {
            var responseContent = await response.Content.ReadAsStringAsync(ct);

            response.EnsureSuccessStatusCode();

            return JsonSerializer.Deserialize<T>(responseContent, SerializerOptions);
        }

        protected static Uri BuildUri(Uri baseUri, string path, IEnumerable<KeyValuePair<string, string>> parameters)
        {
            var builder = new UriBuilder(baseUri)
            {
                Path = path,
                Query = string.Join("&", parameters.Select(x => $"{x.Key}={HttpUtility.UrlEncode(x.Value)}"))
            };

            return builder.Uri;
        }

        private static IEnumerable<KeyValuePair<string, string>> ParseQueryParams(object queryParams)
        {
            return queryParams switch
            {
                null => Enumerable.Empty<KeyValuePair<string, string>>(),
                IEnumerable<KeyValuePair<string, string>> plain => plain,
                _ => queryParams.ToKeyValuePairEnumerable(),
            };
        }
    }
}
