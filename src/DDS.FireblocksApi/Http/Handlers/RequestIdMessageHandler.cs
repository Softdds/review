using System.Diagnostics;

namespace DDS.Utils.Http.Handlers
{
    public sealed class RequestIdMessageHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var activity = Activity.Current;

            if (activity is not null)
                request.Headers.Add("X-Request-ID", activity.TraceId.ToString());

            return base.SendAsync(request, cancellationToken);
        }
    }
}
