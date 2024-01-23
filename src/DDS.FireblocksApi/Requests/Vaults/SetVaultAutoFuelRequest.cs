namespace DDS.FireblocksApi.Requests.Vaults
{
    public class SetVaultAutoFuelRequest
    {
        public SetVaultAutoFuelRequest(bool autoFuel)
        {
            AutoFuel = autoFuel;
        }

        public bool AutoFuel { get; }
    }
}
