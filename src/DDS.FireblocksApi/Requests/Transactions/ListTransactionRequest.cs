namespace DDS.FireblocksApi.Requests.Transactions
{
    public sealed class ListTransactionRequest
    {
        public string Before { get; set; }
        public string After { get; set; }
        public string Status { get; set; }
        public string OrderBy { get; set; }
        public string Sort { get; set; }
        public int Limit { get; set; }
        public string SourceType { get; set; }
        public string SourceId { get; set; }
        public string DestType { get; set; }
        public string DestId { get; set; }
        public string Assets { get; set; }
        public string TxHash { get; set; }
        public string SourceWalletId { get; set; }
        public string DestWalletId { get; set; }

        public ListTransactionRequest Clone()
        {
            return (ListTransactionRequest)MemberwiseClone();
        }
    }
}
