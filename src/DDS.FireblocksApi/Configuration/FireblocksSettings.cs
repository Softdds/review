namespace DDS.FireblocksApi.Configuration
{
    public class FireblocksSettings
    {
        public static readonly string SectionName = "FireblocksApi";

        public string BaseUrl { get; set; }

        public string ApiKey { get; set; }

        public string SecretKey { get; set; }

        public FireblocksWebHooksSettings WebHooks { get; set; }
    }
}
