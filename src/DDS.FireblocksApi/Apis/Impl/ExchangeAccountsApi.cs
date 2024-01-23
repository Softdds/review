using DDS.FireblocksApi.Models;
using DDS.Core.Api;

namespace DDS.FireblocksApi.Apis.Impl
{
    internal class ExchangeAccountsApi : BaseApi, IExchangeAccountsApi
    {
        public ExchangeAccountsApi(HttpClient http) : base(http)
        {
        }

        public Task<IReadOnlyCollection<ExchangeAccount>> GetAsync(CancellationToken ct)
        {
            return ExecuteRequestAsync<IReadOnlyCollection<ExchangeAccount>>(
                "v1/exchange_accounts",
                HttpMethod.Get,
                ct: ct);
        }
    }
}
