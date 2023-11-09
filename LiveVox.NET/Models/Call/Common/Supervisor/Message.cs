using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Supervisor
{
    public class ChatMessage
    {
        /// <summary>
        /// Gets or sets the chat message.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the ID of the sender.
        /// </summary>
        [JsonPropertyName("senderId")]
        public string SenderId { get; set; }

        /// <summary>
        /// Gets or sets the chat timestamp.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
