namespace DDS.FireblocksApi.Models
{
    public sealed class ExchangeAsset
    {
        public ExchangeAsset(string id, decimal total, decimal available, decimal lockedAmount)
        {
            Id = id;
            Total = total;
            Available = available;
            LockedAmount = lockedAmount;
        }

        public string Id { get; }

        public decimal Total { get; }

        public decimal Available { get; }

        public decimal LockedAmount { get; }
    }
}
