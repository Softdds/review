using DDS.FireblocksApi.Models;

namespace DDS.FireblocksApi.Apis
{
    public interface IAccountsApi
    {
        Task<VaultAccount> CreateAsync(string name, bool hiddenOnUi = true, string customerRefId = "", bool autoFuel = false, CancellationToken ct = default);
    }
}
