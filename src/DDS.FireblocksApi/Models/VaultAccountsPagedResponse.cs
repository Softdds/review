namespace DDS.FireblocksApi.Models
{
    public class VaultAccountsPagedResponse
    {
        public VaultAccountsPagedResponse(IReadOnlyCollection<VaultAccount> accounts, Paging paging, string previousUrl, string nextUrl)
        {
            Accounts = accounts;
            Paging = paging;
            PreviousUrl = previousUrl;
            NextUrl = nextUrl;
        }

        public IReadOnlyCollection<VaultAccount> Accounts { get; }

        public Paging Paging { get; }

        public string PreviousUrl { get; }

        public string NextUrl { get; }
    }
}
