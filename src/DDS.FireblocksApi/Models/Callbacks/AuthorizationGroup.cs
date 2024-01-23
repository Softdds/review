namespace DDS.FireblocksApi.Models.Callbacks
{
    public sealed class AuthorizationGroup
    {
        /// <summary>
        /// The threshold of required approvers in this authorization group
        /// </summary>
        public int Th { get; set; }

        /// <summary>
        /// The list of users to which the threshold number is applied for transaction approval.
        /// Each user in the response is a "key:value" where the key is the user ID (found via the List users endpoint) and the value is their ApprovalStatus.
        /// </summary>
        public Dictionary<string, string> Users { get; set; }
    }
}
