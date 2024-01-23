namespace DDS.FireblocksApi.Models
{
    public sealed class VaultAccount
    {
        public VaultAccount(string id, string name, IReadOnlyCollection<VaultAsset> assets, bool hiddenOnUI, bool autoFuel)
        {
            Id = id;
            Name = name;
            Assets = assets;
            HiddenOnUI = hiddenOnUI;
            AutoFuel = autoFuel;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public IReadOnlyCollection<VaultAsset> Assets { get; }

        public bool HiddenOnUI { get; set; }

        public bool AutoFuel { get; set; }
    }
}
