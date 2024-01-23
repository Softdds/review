using DDS.FireblocksApi.Enums;

namespace DDS.FireblocksApi.Models
{
    public sealed class VaultAssetAddress
    {
        public VaultAssetAddress(
            string assetId,
            string address,
            string description,
            string tag,
            string type,
            string customerRefId,
            AddressFormat addressFormat,
            string legacyAddress,
            string enterpriseAddress,
            int bip44AddressIndex,
            bool userDefined)
        {
            AssetId = assetId;
            Address = address;
            Description = description;
            Tag = tag;
            Type = type;
            CustomerRefId = customerRefId;
            AddressFormat = addressFormat;
            LegacyAddress = legacyAddress;
            EnterpriseAddress = enterpriseAddress;
            Bip44AddressIndex = bip44AddressIndex;
            UserDefined = userDefined;
        }

        public string AssetId { get; }

        public string Address { get; }

        public string Description { get; }

        public string Tag { get; }

        public string Type { get; }

        public string CustomerRefId { get; }

        public AddressFormat AddressFormat { get; }

        public string LegacyAddress { get; }

        public string EnterpriseAddress { get; }

        public int Bip44AddressIndex { get; }

        public bool UserDefined { get; }
    }
}
