using DDS.FireblocksApi.Requests.Transactions;
using DDS.FireblocksApi.Responses.Transactions;

namespace DDS.FireblocksApi.Apis.Impl
{
    internal sealed class TransactionsApi : FireblocksBaseApi, ITransactionsApi
    {
        public TransactionsApi(HttpClient http) : base(http)
        {
        }

        public Task<CreateTransactionResponse> CreateAsync(CreateTransactionRequest request, CancellationToken ct)
        {
            return ExecuteRequestAsync<CreateTransactionResponse>(
                "v1/transactions",
                HttpMethod.Post,
                content: request,
                ct: ct);
        }

        public Task<NetworkFeeResponse> EstimateAsync(CreateTransactionRequest request, CancellationToken ct)
        {
            return ExecuteRequestAsync<NetworkFeeResponse>(
                "v1/transactions/estimate_fee",
                HttpMethod.Post,
                content: request,
                ct: ct);
        }

        public Task<TransactionResponse> GetAsync(string transactionId, CancellationToken ct)
        {
            return ExecuteRequestAsync<TransactionResponse>(
                $"v1/transactions/{transactionId}",
                HttpMethod.Get,
                ct: ct);
        }

        public Task<IReadOnlyCollection<TransactionResponse>> ListAsync(ListTransactionRequest request, CancellationToken ct)
        {
            return ExecuteRequestAsync<IReadOnlyCollection<TransactionResponse>>(
                $"v1/transactions",
                HttpMethod.Get,
                queryParams: request,
                ct: ct);
        }
    }
}
