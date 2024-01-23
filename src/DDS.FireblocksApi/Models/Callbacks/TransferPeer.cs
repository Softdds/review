namespace DDS.FireblocksApi.Models.Callbacks
{
    public sealed class TransferPeer
    {
        /// <summary>
        /// [ VAULT_ACCOUNT, EXCHANGE_ACCOUNT, INTERNAL_WALLET, EXTERNAL_WALLET, ONE_TIME_ADDRESS, NETWORK_CONNECTION, FIAT_ACCOUNT, GAS_STATION, UNKNOWN ]
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The ID of the exchange account to return.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The name of the exchange account.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The specific exchange, fiat account, or wallet.
        /// </summary>
        public string SubType { get; set; }
    }
}
