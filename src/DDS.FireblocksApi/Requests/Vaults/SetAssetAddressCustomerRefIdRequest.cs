namespace DDS.FireblocksApi.Requests.Vaults
{
    public class SetAssetAddressCustomerRefIdRequest
    {
        public SetAssetAddressCustomerRefIdRequest(string customerRefId)
        {
            CustomerRefId = customerRefId;
        }

        public string CustomerRefId { get; }
    }
}
