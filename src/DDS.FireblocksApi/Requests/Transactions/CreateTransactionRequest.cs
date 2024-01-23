using DDS.FireblocksApi.Models;

namespace DDS.FireblocksApi.Requests.Transactions
{
    public class CreateTransactionRequest
    {
        public string Operation { get; set; }
        public string Note { get; set; }
        public string ExternalTxId { get; set; }
        public string AssetId { get; set; }
        public SourceRequest Source { get; set; }
        public DestinationRequest Destination { get; set; }
        public IReadOnlyCollection<Destination2Request> Destinations { get; set; }
        public string Amount { get; set; }
        public bool TreatAsGrossAmount { get; set; }
        public bool ForceSweep { get; set; }
        public string FeeLevel { get; set; }
        public string Fee { get; set; }
        public string PriorityFee { get; set; }
        public bool FailOnLowFee { get; set; }
        public string MaxFee { get; set; }
        public string GasLimit { get; set; }
        public string GasPrice { get; set; }
        public string NetworkFee { get; set; }
        public string ReplaceTxByHash { get; set; }
        //public ExtraParameters ExtraParameters { get; set; }
        public string CustomerRefId { get; set; }
    }
}
