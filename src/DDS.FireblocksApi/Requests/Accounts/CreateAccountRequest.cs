namespace DDS.FireblocksApi.Requests.Accounts
{
    internal class CreateAccountRequest
    {
        public CreateAccountRequest(string name, bool hiddenOnUi, string customerRefId, bool autoFuel)
        {
            Name = name;
            HiddenOnUi = hiddenOnUi;
            CustomerRefId = customerRefId;
            AutoFuel = autoFuel;
        }

        public string Name { get; }

        public bool HiddenOnUi { get; }

        public string CustomerRefId { get; }

        public bool AutoFuel { get; }
    }
}
