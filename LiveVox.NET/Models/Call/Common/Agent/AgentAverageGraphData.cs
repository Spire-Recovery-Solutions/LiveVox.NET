using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class AgentAverageGraphData
    {
        /// <summary>
        /// Start time of the graph data.
        /// </summary>
        [JsonPropertyName("startTime")]
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// End time of the graph data.
        /// </summary>
        [JsonPropertyName("endTime")]
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// Comma separated String of values.
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
