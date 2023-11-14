using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Supervisor
{
    public class Chat
    {
        /// <summary>
        /// Array of messages
        /// </summary>
        [JsonPropertyName("messageList")]
        public ICollection<ChatMessage> MessageList { get; set; }

        /// <summary>
        /// Gets or sets the ID of the Agent who is the recipient of the message.
        /// </summary>
        [JsonPropertyName("userLoginId")]
        public string UserLoginId { get; set; }

        /// <summary>
        /// Gets or sets a boolean indicating if the Agent can respond to the message.
        /// </summary>
        [JsonPropertyName("canReply")]
        public bool CanReply { get; set; }
    }
}
