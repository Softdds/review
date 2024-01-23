namespace DDS.FireblocksApi.Requests.Vaults
{
    public class CreateVaultAccountRequest
    {
        public CreateVaultAccountRequest(string name, string customerRefId, bool hiddenOnUi = true, bool autoFuel = false)
        {
            Name = name;
            CustomerRefId = customerRefId;
        }

        public string Name { get; }

        public string CustomerRefId { get; }

        public bool HiddenOnUi { get; set; } = true;

        public bool AutoFuel { get; } = false;
    }
}
