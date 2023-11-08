using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Call.Enumerations.Agent;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class MessagePhrase
    {
        /// <summary>
        /// Message ID.
        /// </summary>
        [JsonPropertyName("messageId")]
        public long MessageId { get; set; }

        /// <summary>
        /// Phrase Label.
        /// </summary>
        [JsonPropertyName("phrase")]
        public string Phrase { get; set; }

        /// <summary>
        /// Prompt content.
        /// </summary>
        [JsonPropertyName("prompt")]
        public string Prompt { get; set; }

        /// <summary>
        /// Language ID
        /// </summary>
        [JsonPropertyName("language")]
        public MessageLanguage Language { get; set; }
    }
}
