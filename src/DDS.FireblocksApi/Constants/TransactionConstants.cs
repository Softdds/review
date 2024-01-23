namespace DDS.FireblocksApi.Constants
{
    public static class TransactionConstants
    {
        /// <summary>
        /// Transaction operation type
        /// </summary>
        public static class Operations
        {
            public const string Transfer = "TRANSFER";
            public const string Mint = "MINT";
            public const string Burn = "BURN";
            public const string ContractCall = "CONTRACT_CALL";
            public const string TypedMessage = "TYPED_MESSAGE";
            public const string Raw = "RAW";
            public const string EnableAsset = "ENABLE_ASSET";
            public const string Stake = "STAKE";
            public const string Unstake = "UNSTAKE";
            public const string Withdraw = "WITHDRAW";
        }

        public static class Peers
        {
            public const string VaultAccount = "VAULT_ACCOUNT";
            public const string ExchangeAccount = "EXCHANGE_ACCOUNT";
            public const string OneTimeAddress = "ONE_TIME_ADDRESS";
        }

        public static class Statuses
        {
            public const string Submitted = "SUBMITTED";
            public const string PendingScreening = "PENDING_AML_SCREENING";
            public const string PendingAuthorization = "PENDING_AUTHORIZATION";
            public const string Queued = "QUEUED";
            public const string PendingSignature = "PENDING_SIGNATURE";
            public const string Pending3rdPartyApproval = "PENDING_3RD_PARTY_MANUAL_APPROVAL";
            public const string Pending3rdParty = "PENDING_3RD_PARTY";
            public const string Broadcasting = "BROADCASTING";
            public const string Confirming = "CONFIRMING";
            public const string Completed = "COMPLETED";
            public const string Cancelling = "CANCELLING";
            public const string Cancelled = "CANCELLED";
            public const string Blocked = "BLOCKED";
            public const string Rejected = "REJECTED";
            public const string Failed = "FAILED";

            public static readonly IReadOnlySet<string> PendingStatuses = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase)
            {
                Submitted,
                PendingScreening,
                PendingAuthorization,
                Queued,
                PendingSignature,
                Pending3rdPartyApproval,
                Pending3rdParty,
                Broadcasting,
                Confirming,
            };

            public static readonly IReadOnlySet<string> FailedStatuses = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase)
            {
                Cancelling,
                Cancelled,
                Blocked,
                Rejected,
                Failed
            };

            public static bool IsPending(string status)
            {
                return PendingStatuses.Contains(status);
            }

            public static bool IsFailed(string status)
            {
                return FailedStatuses.Contains(status);
            }

            public static bool IsSucceed(string status)
            {
                return string.Equals(Completed, status, StringComparison.InvariantCultureIgnoreCase);
            }
        }

        public static class NotificationTypes
        {
            public const string TransactionCreated = "TRANSACTION_CREATED";
            public const string TransactionStatusUpdated = "TRANSACTION_STATUS_UPDATED";
            public const string TransactionApprovalStatusUpdated = "TRANSACTION_APPROVAL_STATUS_UPDATED";

            public static bool Contains(string type)
            {
                return string.Equals(TransactionCreated, type, StringComparison.InvariantCultureIgnoreCase)
                    || string.Equals(TransactionStatusUpdated, type, StringComparison.InvariantCultureIgnoreCase)
                    || string.Equals(TransactionApprovalStatusUpdated, type, StringComparison.InvariantCultureIgnoreCase);
            }
        }
    }
}
