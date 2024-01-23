namespace DDS.FireblocksApi.Requests.Vaults
{
    public class ListVaultAccountPagedRequest : ListVaultAccountRequest
    {
        public ListVaultAccountPagedRequest(int limit = 100)
        {
            Limit = limit;
        }

        public string OrderBy { get; set; } = "DESC";

        public string Before { get; set; }

        public string After { get; set; }

        public int Limit { get; }
    }
}
