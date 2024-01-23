using DDS.FireblocksApi.Models;

namespace DDS.FireblocksApi.Apis
{
    public interface IExchangeAccountsApi
    {
        Task<IReadOnlyCollection<ExchangeAccount>> GetAsync(CancellationToken ct);
    }
}
