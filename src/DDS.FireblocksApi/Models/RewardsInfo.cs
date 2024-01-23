namespace DDS.FireblocksApi.Models
{
    public class RewardsInfo
    {
        public RewardsInfo(string pendingRewards)
        {
            PendingRewards = pendingRewards;
        }

        public string PendingRewards { get; set; }
    }
}
