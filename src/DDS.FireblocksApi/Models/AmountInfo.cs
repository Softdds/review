namespace DDS.FireblocksApi.Models
{
    public class AmountInfo
    {
        /// <summary>
        /// If the transfer is a withdrawal from an exchange, the actual amount that was requested to be transferred.
        /// Otherwise, it is the requested amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// The amount requested by the user
        /// </summary>
        public decimal RequestedAmount { get; set; }

        /// <summary>
        /// The net amount of the transaction, after fee deduction
        /// </summary>
        public decimal NetAmount { get; set; }

        /// <summary>
        /// The USD value of the requested amount
        /// </summary>
        public decimal? AmountUsd { get; set; }
    }
}
