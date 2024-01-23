using DDS.FireblocksApi.Models;

namespace DDS.FireblocksApi.Apis
{
    public interface ICatalogsApi
    {
        Task<IReadOnlyCollection<SupportedAsset>> GetSupportedAssetsAsync(CancellationToken ct);
    }
}
