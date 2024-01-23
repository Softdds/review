namespace DDS.FireblocksApi.Responses.Vaults
{
    public class CreateVaultAssetResponse
    {
        public string Id { get; set; }

        public string Address { get; set; }

        public string LegacyAddress { get; set; }

        public string EnterpriseAddress { get; set; }

        public string Tag { get; set; }

        public string EosAccountName { get; set; }

        public string Status { get; set; }

        public string ActivationTxId { get; set; }
    }
}
