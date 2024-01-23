namespace DDS.FireblocksApi.Requests.Vaults
{
    public class CreateAssetAddressRequest
    {
        public CreateAssetAddressRequest(string description, string customerRefId)
        {
            Description = description;
            CustomerRefId = customerRefId;
        }

        public string Description { get; }

        public string CustomerRefId { get; }
    }
}
