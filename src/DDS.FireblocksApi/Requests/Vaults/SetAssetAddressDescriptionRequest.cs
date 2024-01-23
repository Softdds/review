namespace DDS.FireblocksApi.Requests.Vaults
{
    public class SetAssetAddressDescriptionRequest
    {
        public SetAssetAddressDescriptionRequest(string description)
        {
            Description = description;
        }

        public string Description { get; }
    }
}
