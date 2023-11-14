using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Agent;

namespace LiveVox.NET.Models.Call.Responses.Agent.Message
{
    public class GetMessagesResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Agent Message ID.
        /// </summary>
        [JsonPropertyName("agentMessageId")]
        public long AgentMessageId { get; set; }

        /// <summary>
        /// Description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Array of phrase.
        /// </summary>
        [JsonPropertyName("messages")]
        public ICollection<MessagePhrase> Messages { get; set; }
    }
}
