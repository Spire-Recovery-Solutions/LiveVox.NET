using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Agent;

namespace LiveVox.NET.Models.Call.Responses.Supervisor.Chat
{
    public class GetChatMessageResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets an array of chat messages.
        /// </summary>
        [JsonPropertyName("chatList")]
        public ICollection<ChatMessage> ChatList { get; set; }

        /// <summary>
        /// The most recent timestamp found in the message lists returned.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public DateTimeOffset Timestamp { get; set; }
    }
}
