namespace DDS.FireblocksApi.Models
{
    public class TradingAccount
    {
        public string Type { get; set; }

        public IReadOnlyCollection<ExchangeAsset> Assets { get; set; }
    }
}
