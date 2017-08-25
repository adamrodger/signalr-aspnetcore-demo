namespace SignalR2.AspNetCore.Chat
{
    using Newtonsoft.Json;

    public class ChatMessage
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
