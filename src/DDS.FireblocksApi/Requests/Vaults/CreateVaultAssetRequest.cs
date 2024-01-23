namespace DDS.FireblocksApi.Requests.Vaults
{
    public class CreateVaultAssetRequest
    {
        public CreateVaultAssetRequest(string eosAccountName)
        {
            EosAccountName = eosAccountName;
        }

        public string EosAccountName { get; }
    }
}
