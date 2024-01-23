namespace DDS.FireblocksApi.Responses.Vaults
{
    public class CreateAssetAddressResponse
    {
        public CreateAssetAddressResponse(string address, string legacyAddress, string enterpriseAddress, string tag, int bip44AddressIndex)
        {
            Address = address;
            LegacyAddress = legacyAddress;
            EnterpriseAddress = enterpriseAddress;
            Tag = tag;
            Bip44AddressIndex = bip44AddressIndex;
        }

        public string Address { get; }

        public string LegacyAddress { get; }

        public string EnterpriseAddress { get; }

        public string Tag { get; }

        public int Bip44AddressIndex { get; }
    }
}
