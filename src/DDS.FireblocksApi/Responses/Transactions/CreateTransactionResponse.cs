namespace DDS.FireblocksApi.Responses.Transactions
{
    public class CreateTransactionResponse
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public SystemMessages SystemMessages { get; set; }
    }

    public class SystemMessages
    {
        public string Type { get; set; }
        public string Message { get; set; }
    }
}
