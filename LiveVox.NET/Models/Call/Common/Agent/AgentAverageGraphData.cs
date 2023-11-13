using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class AgentAverageGraphData
    {
        /// <summary>
        /// Start time of the graph data.
        /// </summary>
        [JsonPropertyName("startTime")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// End time of the graph data.
        /// </summary>
        [JsonPropertyName("endTime")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// Comma separated String of values.
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
