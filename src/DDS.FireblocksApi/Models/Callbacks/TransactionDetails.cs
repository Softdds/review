using DDS.FireblocksApi.Responses.Transactions;

namespace DDS.FireblocksApi.Models.Callbacks
{
    public sealed class TransactionDetails
    {
        /// <summary>
        /// The ID of the transaction.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Unique transaction ID provided by the user.
        /// Fireblocks highly recommends setting an externalTxId for every transaction created, to avoid submitting the same transaction twice.
        /// </summary>
        public string ExternalTxId { get; set; }

        /// <summary>
        /// The current primary status of the transaction. See Primary Transaction Statuses for a detailed list.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// See Transaction Substatuses for a detailed list of transaction substatuses.
        /// </summary>
        public string SubStatus { get; set; }

        /// <summary>
        /// The hash of this transaction on the blockchain.
        /// txHash is only returned for crypto assets (not fiat) when the operation type is not RAW or TYPED_MESSAGE.
        /// This parameter exists if at least one of the following conditions is met:
        /// 1) The transaction’s source type is UNKNOWN, WHITELISTED_ADDRESS, ONE_TIME_ADDRESS, FIAT or GAS_STATION.
        /// 2) The transaction’s source type is VAULT and the status is: CONFIRMING, COMPLETED,
        ///     or was either status prior to changing to FAILED or REJECTED.
        ///     In some instances, transactions with the status BROADCASTING will include the txHash as well.
        /// 3) The transaction’s source type is EXCHANGE and the transaction’s destination type is VAULT,
        ///     and the status is: CONFIRMING, COMPLETED, or was either status prior to changing to FAILED.
        /// </summary>
        public string TxHash { get; set; }

        /// <summary>
        /// The transaction operation type. The default is TRANSFER.
        /// [TRANSFER, MINT, BURN, CONTRACT_CALL, TYPED_MESSAGE, RAW, ENABLE_ASSET, STAKE, UNSTAKE, WITHDRAW]
        /// </summary>
        public string Operation { get; set; }

        /// <summary>
        /// Custom note that describes this transaction in your Fireblocks workspace. The note isn’t sent to the blockchain.
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// The ID of the transaction’s asset, for TRANSFER, MINT, BURN or ENABLE_ASSET operations.
        /// See the list of supported assets and their IDs on Fireblocks.
        /// </summary>
        public string AssetId { get; set; }

        /// <summary>
        /// One of the following
        /// [XLM_ASSET, XDB_ASSET, TRON_TRC20, SOL_ASSET, HBAR_ERC20, FIAT, ERC721, ERC20, ERC1155, BEP20, BASE_ASSET, ALGO_ASSET]
        /// </summary>
        public string AssetType { get; set; }

        /// <summary>
        /// The transaction’s source.
        /// </summary>
        public TransferPeer Source { get; set; }

        /// <summary>
        /// For account based assets only, the source address of the transaction.
        /// </summary>
        /// <remarks>
        /// If the status is CONFIRMING, COMPLETED, or was CONFIRMING before either FAILED or REJECTED,
        /// then this parameter will contain the source address. This parameter is empty in any other case.
        /// </remarks>
        public string SourceAddress { get; set; }

        /// <summary>
        /// The transaction’s destination.
        /// </summary>
        /// <remarks>
        /// If a transaction is sent to multiple destinations, the destinations parameter is used instead of destination.
        /// </remarks>
        public TransferPeer Destination { get; set; }

        /// <summary>
        /// For UTXO-based assets, all outputs are specified here.
        /// </summary>
        public IReadOnlyCollection<DestinationResponse> Destinations { get; set; }

        /// <summary>
        /// Address where the asset was transferred.
        /// </summary>
        /// <remarks>
        /// For Multi-destination transactions, this parameter will be empty and you should refer to the destinations field instead.
        /// If the status is CONFIRMING, COMPLETED, or was CONFIRMING before either FAILED or REJECTED,
        /// then this parameter will contain the destination address. This parameter is empty in any other case.
        /// </remarks>
        public string DestinationAddress { get; set; }

        /// <summary>
        /// Description of the address
        /// </summary>
        public string DestinationAddressDescription { get; set; }

        /// <summary>
        /// (Optional) Destination address tag for Ripple; destination memo for EOS, Stellar, Hedera, & DigitalBits;
        /// destination note for Algorand; bank transfer description for fiat providers.
        /// </summary>
        public string DestinationTag { get; set; }

        /// <summary>
        /// For TRANSFER operations, all details of the transfer amount.
        /// </summary>
        public AmountInfo AmountInfo { get; set; }

        /// <summary>
        /// When set to true, the fee is deducted from the requested amount for transactions initiated from this Fireblocks workspace.
        /// </summary>
        public bool TreatAsGrossAmount { get; set; }

        /// <summary>
        /// Details of the transaction's fee.
        /// </summary>
        public FeeInfo FeeInfo { get; set; }

        /// <summary>
        /// The asset type used to pay the fee (ETH for ERC-20 tokens, BTC for Omni, XLM for Stellar tokens, etc.)
        /// </summary>
        public string FeeCurrency { get; set; }

        //public IReadOnlyCollection<NetworkRecord> NetworkRecords { get; set; }

        /// <summary>
        /// The transaction’s creation date and time, in Unix timestamp.
        /// </summary>
        public long CreatedAt { get; set; }

        /// <summary>
        /// The transaction’s last update date and time, in Unix timestamp.
        /// </summary>
        public long LastUpdated { get; set; }

        /// <summary>
        /// User ID of the initiator of this transaction.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// User ID(s) of the signer(s) of this transaction.
        /// </summary>
        public IReadOnlyCollection<string> SignedBy { get; set; }

        /// <summary>
        /// User ID of the user that rejected the transaction, only if the transaction was rejected.
        /// </summary>
        public string RejectedBy { get; set; }

        //public AuthorizationInfo AuthorizationInfo { get; set; }

        /// <summary>
        /// If the transaction originated from an exchange, this is the exchange’s ID of this transaction.
        /// </summary>
        public string ExchangeTxId { get; set; }

        /// <summary>
        /// The ID for AML providers to associate the owner of the funds with the transaction.
        /// </summary>
        public string CustomerRefId { get; set; }

        //public AmlScreeningResult AmlScreeningResult { get; set; }

        /// <summary>
        /// The hash of the replaced transaction, only If this is an RBF transaction on an EVM blockchain.
        /// </summary>
        public string ReplacedTxHash { get; set; }

        /// <summary>
        /// Parameters that are specific to some transaction operation types and blockchain networks.
        /// </summary>
        public ExtraParameters ExtraParameters { get; set; }

        //public IReadOnlyCollection<SignedMessage> SignedMessages { get; set; }

        /// <summary>
        /// The number of blockchain confirmations of the transaction.
        /// The number will increase until the transaction is considered completed according to the confirmation policy.
        /// </summary>
        public int NumberOfConfirmations { get; set; }

        //public BlockInfo BlockInfo { get; set; }

        /// <summary>
        /// [Optional] For UTXO-based assets this is the vOut, for EVM based, this is the index of the event of the contract call.
        /// </summary>
        /// <remarks>
        /// This field is not returned if a transaction uses the destinations object with more than one value.
        /// </remarks>
        public int Index { get; set; }

        //public RewardsInfo RewardsInfo { get; set; }

        //public IReadOnlyCollection<SystemMessageInfo> SystemMessages { get; set; }

        /// <summary>
        /// (Optional) [ONE_TIME, WHITELISTED]
        /// </summary>
        public string AddressType { get; set; }

        /// <summary>
        /// The amount requested by the user.
        /// </summary>
        [Obsolete("Deprecated")]
        public decimal? RequestedAmount { get; set; }

        /// <summary>
        /// If the transfer is a withdrawal from an exchange, the actual transfer amount. Otherwise, the requested amount.
        /// </summary>
        [Obsolete("Deprecated")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The net amount of the transfer, after fee deduction.
        /// </summary>
        [Obsolete("Deprecated")]
        public decimal? NetAmount { get; set; }

        /// <summary>
        /// The USD value of the requested amount.
        /// </summary>
        [Obsolete("Deprecated")]
        public decimal? AmountUsd { get; set; }

        /// <summary>
        /// The total fee deducted by the exchange from the actual requested amount (serviceFee = amount - netAmount).
        /// </summary>
        [Obsolete("Deprecated")]
        public decimal? ServiceFee { get; set; }

        /// <summary>
        /// The fee paid to the blockchain network.
        /// </summary>
        [Obsolete("Deprecated")]
        public decimal? NetworkFee { get; set; }
    }
}
