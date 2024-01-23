namespace DDS.FireblocksApi.Requests.Vaults
{
    public class ListVaultAccountRequest
    {
        public string NamePrefix { get; set; }

        public string NameSuffix { get; set; }

        public decimal? MinAmountThreshold { get; set; }

        public string AssetId { get; set; }
    }
}
