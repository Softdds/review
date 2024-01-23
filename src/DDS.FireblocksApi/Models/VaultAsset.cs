namespace DDS.FireblocksApi.Models
{
    public sealed class VaultAsset
    {
        public VaultAsset(
            string id,
            decimal total,
            decimal available,
            decimal pending,
            decimal frozen,
            decimal lockedAmount,
            decimal staked,
            string blockHeight,
            string blockHash,
            RewardsInfo rewardsInfo)
        {
            Id = id;
            Total = total;
            Available = available;
            Pending = pending;
            Frozen = frozen;
            LockedAmount = lockedAmount;
            Staked = staked;
            BlockHeight = blockHeight;
            BlockHash = blockHash;
            RewardsInfo = rewardsInfo;
        }

        public string Id { get; }

        /// <summary>
        /// The total wallet balance. In EOS this value includes the network balance, self staking and pending refund. For all other coins it is the balance as it appears on the blockchain.
        /// </summary>
        public decimal Total { get; }

        /// <summary>
        /// Funds available for transfer. Equals the blockchain balance minus any locked amounts
        /// </summary>
        public decimal Available { get; }

        /// <summary>
        /// The cumulative balance of all transactions pending to be cleared
        /// </summary>
        public decimal Pending { get; }

        /// <summary>
        /// The cumulative frozen balance
        /// </summary>
        public decimal Frozen { get; }

        /// <summary>
        /// Funds in outgoing transactions that are not yet published to the network
        /// </summary>
        public decimal LockedAmount { get; }

        /// <summary>
        /// Staked balance
        /// </summary>
        public decimal Staked { get; }

        public string BlockHeight { get; }

        public string BlockHash { get; }

        public RewardsInfo RewardsInfo { get; }
    }
}
