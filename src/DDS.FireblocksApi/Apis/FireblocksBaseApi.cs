using System.Text.Json;
using DDS.FireblocksApi.Json;
using DDS.Core.Api;
using DDS.FireblocksApi.Responses;

namespace DDS.FireblocksApi.Apis
{
    internal abstract class FireblocksBaseApi : BaseApi
    {
        protected override JsonSerializerOptions SerializerOptions => JsonSerializerOptionsEx.DefaultOptions;

        protected FireblocksBaseApi(HttpClient http) : base(http)
        {
        }

        protected override async Task<T> HandleResponseAsync<T>(HttpResponseMessage response, CancellationToken ct)
        {
            var responseContent = await response.Content.ReadAsStringAsync(ct);

            if (!typeof(FireblocksResponse).IsAssignableFrom(typeof(T)))
            {
                response.EnsureSuccessStatusCode();
            }

            return JsonSerializer.Deserialize<T>(responseContent, SerializerOptions);
        }
    }
}
