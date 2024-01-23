namespace DDS.FireblocksApi.Configuration
{
    public class FireblocksWebHooksSettings
    {
        public IReadOnlyCollection<string> AllowedIPs { get; set; }

        public string SignatureKey { get; set; }
    }
}
