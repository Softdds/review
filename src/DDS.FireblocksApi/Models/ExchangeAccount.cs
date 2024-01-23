namespace DDS.FireblocksApi.Models
{
    public sealed class ExchangeAccount
    {
        public string Id { get; set; }

        public string Type { get; set; }

        /// <remarks>Not used</remarks>
        //public string Name { get; set; }

        public string Status { get; set; }

        public IReadOnlyCollection<ExchangeAsset> Assets { get; set; }

        /// <remarks>Not used</remarks>
        //public bool IsSubaccount { get; set; }

        /// <remarks>Not used</remarks>
        //public string MainAccountId { get; set; }

        /// <remarks>Not used</remarks>
        //public IReadOnlyCollection<TradingAccount> TradingAccounts { get; set; }

        /// <remarks>Not used</remarks>
        //public string FundableAccountType { get; set; }
    }
}
