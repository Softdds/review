namespace DDS.FireblocksApi.Responses
{
    public class FireblocksResponse
    {
        public int Code { get; set; }

        public string Message { get; set; }

        public bool IsSuccess => Code == 0 && string.IsNullOrEmpty(Message);
    }
}
