using DDS.FireblocksApi.Apis;
using DDS.FireblocksApi.Apis.Impl;

namespace DDS.FireblocksApi
{
    internal sealed class FireblocksClient : IFireblocksClient
    {
        public ICatalogsApi Catalogs { get; }

        public IExchangeAccountsApi ExchangeAccounts { get; }

        public ITransactionsApi Transactions { get; }

        public IVaultsApi Vaults { get; }

        public FireblocksClient(HttpClient http)
        {
            Catalogs = new CatalogsApi(http);
            ExchangeAccounts = new ExchangeAccountsApi(http);
            Transactions = new TransactionsApi(http);
            Vaults = new VaultsApi(http);
        }
    }
}