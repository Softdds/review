namespace DDS.FireblocksApi.Requests.Transactions
{
    public class DestinationRequest
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string SubType { get; set; }
        public string WalletId { get; set; }
        public OneTimeAddressRequest OneTimeAddress { get; set; }
    }
}
