namespace DDS.FireblocksApi.Requests.Vaults
{
    public sealed class SetVaultCustomerRefIdRequest
    {
        public SetVaultCustomerRefIdRequest(string customerRefId)
        {
            CustomerRefId = customerRefId;
        }

        public string CustomerRefId { get; }
    }
}
