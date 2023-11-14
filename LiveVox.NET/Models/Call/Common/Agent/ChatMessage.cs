using LiveVox.NET.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class ChatMessage
    {
        /// <summary>
        /// Source ID
        /// </summary>
        [JsonPropertyName("sourceId")]
        public string SourceId { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// Time
        /// </summary>
        [JsonPropertyName("time")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset Time { get; set; }
    }
}
