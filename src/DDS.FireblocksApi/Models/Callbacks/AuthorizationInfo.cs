namespace DDS.FireblocksApi.Models.Callbacks
{
    public sealed class AuthorizationInfo
    {
        /// <summary>
        /// Set to "true" if the initiator of the transaction can be one of the approvers
        /// </summary>
        public bool AllowOperatorAsAuthorizer { get; set; }

        /// <summary>
        /// "AND" or "OR"; is the logic that is applied between the different authorization groups listed below.
        /// </summary>
        public string Logic { get; set; }

        /// <summary>
        /// The list of authorization groups and users that are required to approve this transaction.
        /// The logic applied between the different groups is the “logic” field above.
        /// Each element in the response is the user ID (found via the List users endpoint) and the value is their ApprovalStatus
        /// </summary>
        public IReadOnlyCollection<AuthorizationGroup> Groups { get; set; }
    }
}
