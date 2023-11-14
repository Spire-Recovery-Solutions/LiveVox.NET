using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class ChatDetails
    {
        /// <summary>
        /// Chat message.
        /// </summary>
        [JsonPropertyName("chatMessage")]
        public string ChatMessage { get; set; }

        /// <summary>
        /// Chat time.
        /// </summary>
        [JsonPropertyName("chatTime")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset ChatTime { get; set; }

        /// <summary>
        /// Chat user.
        /// </summary>
        [JsonPropertyName("chatUser")]
        public string ChatUser { get; set; }

        /// <summary>
        /// Array of chat messages.
        /// </summary>
        [JsonPropertyName("chatMessages")]
        public ICollection<ChatMessage> ChatMessages { get; set; }

        /// <summary>
        /// Array of terminated chat sessions.
        /// List of source IDs that ended a chat session.
        /// </summary>
        [JsonPropertyName("terminatedChatSessions")]
        public ICollection<string> TerminatedChatSessions { get; set; }
    }
}
