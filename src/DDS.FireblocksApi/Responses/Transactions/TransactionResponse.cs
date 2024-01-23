using DDS.FireblocksApi.Models;

namespace DDS.FireblocksApi.Responses.Transactions
{
    public class TransactionResponse : FireblocksResponse
    {
        /// <summary>
        /// ID of the transaction.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Unique transaction ID provided by the user.
        /// Fireblocks highly recommends setting an externalTxId for every transaction created, to avoid submitting the same transaction twice.
        /// </summary>
        public string ExternalTxId { get; set; }

        /// <summary>
        /// The primary status of the transaction
        /// </summary>
        /// <remarks>
        /// https://developers.fireblocks.com/reference/primary-transaction-statuses
        /// </remarks>
        public string Status { get; set; }

        /// <summary>
        /// The substatus of the transaction
        /// </summary>
        /// <remarks>
        /// https://developers.fireblocks.com/reference/transaction-substatuses
        /// </remarks>
        public string SubStatus { get; set; }

        /// <summary>
        /// The hash of the transaction on the blockchain.
        /// This parameter exists if at least one of the following conditions is met:
        ///     1. The transaction’s source type is
        ///         UNKNOWN
        ///         WHITELISTED_ADDRESS
        ///         NETWORK_CONNECTION
        ///         ONE_TIME_ADDRESS
        ///         FIAT_ACCOUNT
        ///         GAS_STATION
        ///     2. The transaction’s source type is VAULT and the status is either: CONFIRMING, COMPLETED,
        ///         or was in any of these statuses prior to changing to FAILED or REJECTED.
        ///         In some instances, transactions in status BROADCASTING will include the txHash as well.
        ///     3. The transaction’s source type is EXCHANGE_ACCOUNT and the transaction’s destination type is VAULT,
        ///         and the status is either: CONFIRMING, COMPLETED, or was in any of these status prior to changing to FAILED.
        /// In addition, the following conditions must be met:
        ///     1. The asset is a crypto asset (not fiat).
        ///     2. The transaction operation is not RAW or TYPED_MESSAGE.
        /// </summary>
        public string TxHash { get; set; }

        /// <summary>
        /// Type of operations. <see cref="TransactionConstants."/>
        /// </summary>
        public string Operation { get; set; }

        public long CreatedAt { get; set; }

        public long LastUpdated { get; set; }

        public string AssetId { get; set; }

        public SourceResponse Source { get; set; }
        public DestinationResponse Destination { get; set; }

        public string SourceAddress { get; set; }
        public string DestinationAddress { get; set; }
        public string DestinationAddressDescription { get; set; }
        public string DestinationTag { get; set; }
        public List<object> SignedBy { get; set; }
        public string CreatedBy { get; set; }
        public string RejectedBy { get; set; }
        public string AddressType { get; set; }
        public string Note { get; set; }
        public string ExchangeTxId { get; set; }
        public object RequestedAmount { get; set; }

        public AmountInfo AmountInfo { get; set; }

        public FeeInfo FeeInfo { get; set; }

        public string FeeCurrency { get; set; }

        //public ExtraParameters ExtraParameters { get; set; }
        public string AssetType { get; set; }

        #region Obsolete properties

        [Obsolete("Deprecated - please use the amountInfo field for accuracy.")]
        public decimal? Amount { get; set; }

        [Obsolete("Deprecated - please use the amountInfo field for accuracy.")]
        public decimal? NetAmount { get; set; }

        [Obsolete("Deprecated - please use the amountInfo field for accuracy.")]
        public decimal? AmountUSD { get; set; }

        [Obsolete("Deprecated - please use the feeInfo field for accuracy.")]
        public decimal? Fee { get; set; }

        [Obsolete("Deprecated - please use the feeInfo field for accuracy.")]
        public decimal? NetworkFee { get; set; }

        [Obsolete("Deprecated - please use the feeInfo field for accuracy.")]
        public decimal? ServiceFee { get; set; }

        #endregion Obsolete properties
    }
}
