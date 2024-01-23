using DDS.FireblocksApi.Models;

namespace DDS.FireblocksApi.Responses.Transactions
{
    public sealed class NetworkFeeResponse
    {
        public FeeStat Low { get; set; }
        public FeeStat Medium { get; set; }
        public FeeStat High { get; set; }
    }
}

