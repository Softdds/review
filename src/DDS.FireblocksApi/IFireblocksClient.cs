using DDS.FireblocksApi.Apis;

namespace DDS.FireblocksApi
{
    public interface IFireblocksClient
    {
        ICatalogsApi Catalogs { get; }

        IExchangeAccountsApi ExchangeAccounts { get; }

        ITransactionsApi Transactions { get; }

        IVaultsApi Vaults { get; }
    }
}
