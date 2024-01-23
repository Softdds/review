namespace DDS.FireblocksApi.Models.Callbacks
{
    public sealed class SystemMessageInfo
    {
        /// <summary>
        /// [WARN, BLOCK]
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// A response from Fireblocks that communicates a message about the health of the process being performed.
        /// If this object is returned with data, you should expect potential delays or incomplete transaction statuses.
        /// </summary>
        public string Message { get; set; }
    }
}
