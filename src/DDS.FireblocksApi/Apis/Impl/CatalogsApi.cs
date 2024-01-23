using DDS.Core.Api;
using DDS.FireblocksApi.Models;

namespace DDS.FireblocksApi.Apis.Impl
{
    internal class CatalogsApi : BaseApi, ICatalogsApi
    {
        public CatalogsApi(HttpClient http) : base(http)
        {
        }

        public Task<IReadOnlyCollection<SupportedAsset>> GetSupportedAssetsAsync(CancellationToken ct)
        {
            return ExecuteRequestAsync<IReadOnlyCollection<SupportedAsset>>(
                "v1/supported_assets",
                HttpMethod.Get,
                ct: ct);
        }
    }
}
