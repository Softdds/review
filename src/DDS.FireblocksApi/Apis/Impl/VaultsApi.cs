using DDS.Core.Api;
using DDS.FireblocksApi.Models;
using DDS.FireblocksApi.Requests.Vaults;
using DDS.FireblocksApi.Responses;
using DDS.FireblocksApi.Responses.Vaults;

namespace DDS.FireblocksApi.Apis.Impl
{
    internal class VaultsApi : BaseApi, IVaultsApi
    {
        public VaultsApi(HttpClient http) : base(http)
        {
        }

        /// <inheritdoc />
        public Task<VaultAccount> CreateAccountAsync(
            CreateVaultAccountRequest request,
            CancellationToken ct)
        {
            return ExecuteRequestAsync<VaultAccount>(
                "v1/vault/accounts",
                HttpMethod.Post,
                content: request,
                ct: ct);
        }

        [Obsolete("This endpoint is unavailable. Use ListAccountsPagedAsync for paged response of your vault accounts.")]
        public Task<IReadOnlyCollection<VaultAccount>> ListAccountsAsync(
            ListVaultAccountRequest request,
            CancellationToken ct)
        {
            return ExecuteRequestAsync<IReadOnlyCollection<VaultAccount>>(
                "v1/vault/accounts",
                HttpMethod.Get,
                queryParams: request,
                ct: ct);
        }

        /// <inheritdoc />
        public Task<VaultAccountsPagedResponse> ListAccountsPagedAsync(
            ListVaultAccountPagedRequest request,
            CancellationToken ct)
        {
            return ExecuteRequestAsync<VaultAccountsPagedResponse>(
                "v1/vault/accounts_paged",
                HttpMethod.Get,
                queryParams: request,
                ct: ct);
        }

        /// <inheritdoc />
        public Task<VaultAccount> GetAccountAsync(string vaultAccountId, CancellationToken ct)
        {
            return ExecuteRequestAsync<VaultAccount>(
                $"v1/vault/accounts/{vaultAccountId}",
                HttpMethod.Get,
                ct: ct);
        }

        /// <inheritdoc />
        public Task<VaultAccount> RenameAccountAsync(string vaultAccountId, RenameVaultAccountRequest request, CancellationToken ct)
        {
            return ExecuteRequestAsync<VaultAccount>(
                $"v1/vault/accounts/{vaultAccountId}",
                HttpMethod.Put,
                content: request,
                ct: ct);
        }

        /// <inheritdoc />
        public Task<ErrorResponse> HideAccountAsync(string vaultAccountId, CancellationToken ct)
        {
            return ExecuteRequestAsync<ErrorResponse>(
                $"v1/vault/accounts/{vaultAccountId}/hide",
                HttpMethod.Post,
                ct: ct);
        }

        /// <inheritdoc />
        public Task<ErrorResponse> UnhideAccountAsync(string vaultAccountId, CancellationToken ct)
        {
            return ExecuteRequestAsync<ErrorResponse>(
                $"v1/vault/accounts/{vaultAccountId}/unhide",
                HttpMethod.Post,
                ct: ct);
        }

        /// <inheritdoc />
        public Task<CreateVaultAssetResponse> ActivateAccountAsync(string vaultAccountId, string assetId, CancellationToken ct)
        {
            return ExecuteRequestAsync<CreateVaultAssetResponse>(
                $"v1/vault/accounts/{vaultAccountId}/{assetId}/activate",
                HttpMethod.Post,
                ct: ct);
        }

        /// <inheritdoc />
        public Task<ErrorResponse> SetCustomerRefIdAsync(string vaultAccountId, SetVaultCustomerRefIdRequest request, CancellationToken ct)
        {
            return ExecuteRequestAsync<ErrorResponse>(
                $"v1/vault/accounts/{vaultAccountId}/set_customer_ref_id",
                HttpMethod.Post,
                content: request,
                ct: ct);
        }

        /// <inheritdoc />
        public Task<ErrorResponse> SetAutoFuelAsync(string vaultAccountId, SetVaultAutoFuelRequest request, CancellationToken ct)
        {
            return ExecuteRequestAsync<ErrorResponse>(
                $"v1/vault/accounts/{vaultAccountId}/set_auto_fuel",
                HttpMethod.Post,
                content: request,
                ct: ct);
        }

        /// <inheritdoc />
        public Task<VaultAsset> GetVaultAssetAsync(string vaultAccountId, string assetId, CancellationToken ct)
        {
            return ExecuteRequestAsync<VaultAsset>(
                $"v1/vault/accounts/{vaultAccountId}/{assetId}",
                HttpMethod.Get,
                ct: ct);
        }

        /// <inheritdoc />
        public Task<VaultAsset> CreateVaultAssetAsync(string vaultAccountId, string assetId, CreateVaultAssetRequest request, CancellationToken ct)
        {
            return ExecuteRequestAsync<VaultAsset>(
                $"v1/vault/accounts/{vaultAccountId}/{assetId}",
                HttpMethod.Post,
                content: request,
                ct: ct);
        }

        /// <inheritdoc />
        public Task<VaultAsset> RefreshVaultAssetBalanceAsync(string vaultAccountId, string assetId, CancellationToken ct)
        {
            return ExecuteRequestAsync<VaultAsset>(
                $"v1/vault/accounts/{vaultAccountId}/{assetId}/balance",
                HttpMethod.Post,
                content: new { },
                ct: ct);
        }

        public Task<VaultAssetAddress> GetAssetAddressesAsync(string vaultAccountId, string assetId, CancellationToken ct)
        {
            return ExecuteRequestAsync<VaultAssetAddress>(
                $"v1/vault/accounts/{vaultAccountId}/{assetId}/addresses",
                HttpMethod.Get,
                ct: ct);
        }

        public Task<CreateAssetAddressResponse> CreateAssetAddressAsync(string vaultAccountId, string assetId, CreateAssetAddressRequest request, CancellationToken ct)
        {
            return ExecuteRequestAsync<CreateAssetAddressResponse>(
                $"v1/vault/accounts/{vaultAccountId}/{assetId}/addresses",
                HttpMethod.Post,
                content: request,
                ct: ct);
        }

        public Task<ErrorResponse> SetAddressDescriptionAsync(string vaultAccountId, string assetId, string addressId, SetAssetAddressDescriptionRequest request, CancellationToken ct)
        {
            return ExecuteRequestAsync<ErrorResponse>(
                $"v1/vault/accounts/{vaultAccountId}/{assetId}/addresses/{addressId}",
                HttpMethod.Put,
                content: request,
                ct: ct);
        }

        public Task<ErrorResponse> SetAddressCustomerRefIdAsync(string vaultAccountId, string assetId, string addressId, SetAssetAddressCustomerRefIdRequest request, CancellationToken ct)
        {
            return ExecuteRequestAsync<ErrorResponse>(
                $"v1/vault/accounts/{vaultAccountId}/{assetId}/addresses/{addressId}/set_customer_ref_id",
                HttpMethod.Post,
                content: request,
                ct: ct);
        }

        public Task<CreateAssetAddressResponse> CreateAssetAddressLegacyAsync(string vaultAccountId, string assetId, string addressId, CancellationToken ct)
        {
            return ExecuteRequestAsync<CreateAssetAddressResponse>(
                $"v1/vault/accounts/{vaultAccountId}/{assetId}/addresses/{addressId}/create_legacy",
                HttpMethod.Post,
                ct: ct);
        }
    }
}
