namespace DDS.FireblocksApi.Models
{
    public class ExtraParameters
    {
        /// <summary>
        /// For RAW operations, use the rawMessageData field with the values set to the raw message data structure.
        /// Only included with raw signing transactions on Bitcoin and Ethereum.
        /// This is an opt-in feature
        /// </summary>
        public RawMessageData RawMessageData { get; set; }

        /// <summary>
        /// For CONTRACT_CALL operations, use the contractCallData field with the value set to the Ethereum smart contract Application Binary Interface (ABI) payload.
        /// </summary>
        public string ContractCallData { get; set; }
    }
}
