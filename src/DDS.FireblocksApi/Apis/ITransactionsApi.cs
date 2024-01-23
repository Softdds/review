using DDS.FireblocksApi.Requests.Transactions;
using DDS.FireblocksApi.Responses.Transactions;

namespace DDS.FireblocksApi.Apis
{
    public interface ITransactionsApi
    {
        Task<CreateTransactionResponse> CreateAsync(CreateTransactionRequest request, CancellationToken ct);

        Task<NetworkFeeResponse> EstimateAsync(CreateTransactionRequest request, CancellationToken ct);

        Task<IReadOnlyCollection<TransactionResponse>> ListAsync(ListTransactionRequest request, CancellationToken ct);

        Task<TransactionResponse> GetAsync(string transactionId, CancellationToken ct);
    }
}
