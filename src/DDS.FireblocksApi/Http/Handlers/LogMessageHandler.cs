using System.Net.Http.Json;
using Microsoft.Extensions.Logging;

namespace DDS.Utils.Http.Handlers
{
    public sealed class LogMessageHandler : DelegatingHandler
    {
        private readonly ILogger<LogMessageHandler> _log;

        public LogMessageHandler(ILogger<LogMessageHandler> log)
        {
            _log = log;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var logId = Guid.NewGuid().ToString()[..8];

            {
                var content = ShouldLogContent(request.Content) ? await request.Content.ReadAsStringAsync(cancellationToken) : "<null>";

                _log.LogInformation(
                    "Request {logId}: {request}{newLine}{content}",
                    logId,
                    request.ToString(),
                    Environment.NewLine,
                    content);
            }

            var response = await base.SendAsync(request, cancellationToken);

            {
                var content = ShouldLogContent(response.Content) ? await response.Content.ReadAsStringAsync(cancellationToken) : "<null>";

                _log.LogInformation(
                    "Response {logId}: {response}{newLine}{content}",
                    logId,
                    response.ToString(),
                    Environment.NewLine,
                    content);
            }

            return response;
        }

        private static bool ShouldLogContent(HttpContent content)
        {
            if (content != null)
            {
                if (content is StringContent
                    || content is JsonContent
                    || string.Equals(content.Headers.ContentType?.MediaType, "application/json", StringComparison.InvariantCultureIgnoreCase)
                    || string.Equals(content.Headers.ContentType?.MediaType, "text/json", StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
