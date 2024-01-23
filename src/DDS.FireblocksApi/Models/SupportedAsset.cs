using DDS.FireblocksApi.Enums;

namespace DDS.FireblocksApi.Models
{
    public class SupportedAsset
    {
        public SupportedAsset(string id, string name, AssetType type, string contractAddress, string nativeAsset, int decimals)
        {
            Id = id;
            Name = name;
            Type = type;
            ContractAddress = contractAddress;
            NativeAsset = nativeAsset;
            Decimals = decimals;
        }

        public string Id { get; }

        public string Name { get; }

        public AssetType Type { get; }

        public string ContractAddress { get; }

        public string NativeAsset { get; }

        public int Decimals { get; }
    }
}
