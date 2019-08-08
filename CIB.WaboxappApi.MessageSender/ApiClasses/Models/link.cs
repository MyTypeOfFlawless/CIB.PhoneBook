namespace CIB.WaboxappApi.MessageSender.ApiClasses.Models
{
    public class link
    {
        public string token { get; set; }
        public string uid { get; set; }
        public string to { get; set; }
        public string custom_uid { get; set; }
        public string url { get; set; }
        /// <summary>
        /// Optional
        /// </summary>
        public string caption { get; set; }
        /// <summary>
        /// Optional
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// Optional
        /// </summary>
        public string url_thumb { get; set; }
    }
}
