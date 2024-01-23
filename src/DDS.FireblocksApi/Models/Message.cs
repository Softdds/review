namespace DDS.FireblocksApi.Models
{
    public class Message
    {
        public Message(string type, int index, string content)
        {
            Type = type;
            Index = index;
            Content = content;
        }

        public string Type { get; }
        public int Index { get; }
        public string Content { get; }
    }
}
