using DDS.FireblocksApi.Models;
using DDS.FireblocksApi.Requests.Vaults;
using DDS.FireblocksApi.Responses;
using DDS.FireblocksApi.Responses.Vaults;

namespace DDS.FireblocksApi.Apis
{
    public interface IVaultsApi
    {
        [Obsolete("This endpoint is unavailable. Use ListAccountsPagedAsync for paged response of your vault accounts.")]
        Task<IReadOnlyCollection<VaultAccount>> ListAccountsAsync(ListVaultAccountRequest request, CancellationToken ct = default);

        /// <summary>
        /// Gets all vault accounts in your workspace. This endpoint returns a limited amount of results with a quick response time
        /// </summary>
        Task<VaultAccountsPagedResponse> ListAccountsPagedAsync(ListVaultAccountPagedRequest request, CancellationToken ct = default);

        /// <summary>
        /// Creates a new vault account with the requested name
        /// </summary>
        Task<VaultAccount> CreateAccountAsync(CreateVaultAccountRequest request, CancellationToken ct = default);

        /// <summary>
        /// Find a vault account by ID
        /// </summary>
        Task<VaultAccount> GetAccountAsync(string vaultAccountId, CancellationToken ct = default);

        /// <summary>
        /// Renames the requested vault account
        /// </summary>
        Task<VaultAccount> RenameAccountAsync(string vaultAccountId, RenameVaultAccountRequest request, CancellationToken ct = default);

        /// <summary>
        /// Hides the requested vault account from the web console view
        /// </summary>
        Task<ErrorResponse> HideAccountAsync(string vaultAccountId, CancellationToken ct = default);

        /// <summary>
        /// Makes a hidden vault account visible in web console view
        /// </summary>
        Task<ErrorResponse> UnhideAccountAsync(string vaultAccountId, CancellationToken ct = default);

        /// <summary>
        /// Makes a hidden vault account visible in web console view
        /// </summary>
        Task<CreateVaultAssetResponse> ActivateAccountAsync(string vaultAccountId, string assetId, CancellationToken ct = default);

        /// <summary>
        /// Assigns an AML/KYT customer reference ID for the vault account
        /// </summary>
        Task<ErrorResponse> SetCustomerRefIdAsync(string vaultAccountId, SetVaultCustomerRefIdRequest request, CancellationToken ct = default);

        /// <summary>
        /// Sets the autofueling property of the vault account to enabled or disabled
        /// </summary>
        Task<ErrorResponse> SetAutoFuelAsync(string vaultAccountId, SetVaultAutoFuelRequest request, CancellationToken ct = default);

        /// <summary>
        /// Returns a wallet for a specific asset of a vault account
        /// </summary>
        Task<VaultAsset> GetVaultAssetAsync(string vaultAccountId, string assetId, CancellationToken ct = default);

        /// <summary>
        /// Creates a wallet for a specific asset in a vault account
        /// </summary>
        Task<VaultAsset> CreateVaultAssetAsync(string vaultAccountId, string assetId, CreateVaultAssetRequest request, CancellationToken ct = default);

        /// <summary>
        /// Updates the balance of a specific asset in a vault account
        /// </summary>
        Task<VaultAsset> RefreshVaultAssetBalanceAsync(string vaultAccountId, string assetId, CancellationToken ct = default);

        /// <summary>
        /// Lists all addresses for specific asset of vault account
        /// </summary>
        Task<VaultAssetAddress> GetAssetAddressesAsync(string vaultAccountId, string assetId, CancellationToken ct = default);

        /// <summary>
        /// Creates a new deposit address for an asset of a vault account
        /// </summary>
        Task<CreateAssetAddressResponse> CreateAssetAddressAsync(string vaultAccountId, string assetId, CreateAssetAddressRequest request, CancellationToken ct = default);

        /// <summary>
        /// Updates the description of an existing address of an asset in a vault account
        /// </summary>
        Task<ErrorResponse> SetAddressDescriptionAsync(string vaultAccountId, string assetId, string addressId, SetAssetAddressDescriptionRequest request, CancellationToken ct = default);

        /// <summary>
        /// Sets an AML/KYT customer reference ID for a specific address
        /// </summary>
        Task<ErrorResponse> SetAddressCustomerRefIdAsync(string vaultAccountId, string assetId, string addressId, SetAssetAddressCustomerRefIdRequest request, CancellationToken ct = default);

        /// <summary>
        /// Converts an existing segwit address to the legacy format
        /// </summary>
        Task<CreateAssetAddressResponse> CreateAssetAddressLegacyAsync(string vaultAccountId, string assetId, string addressId, CancellationToken ct = default);
    }
}
