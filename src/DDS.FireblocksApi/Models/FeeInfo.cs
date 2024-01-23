namespace DDS.FireblocksApi.Models
{
    public sealed class FeeInfo
    {
        /// <summary>
        /// The fee paid to the network
        /// </summary>
        public decimal NetworkFee { get; set; }

        /// <summary>
        /// The total fee deducted by the exchange from the actual requested amount (serviceFee = amount - netAmount)
        /// </summary>
        public decimal ServiceFee { get; set; }

        public decimal? GasPrice { get; set; }
    }
}
