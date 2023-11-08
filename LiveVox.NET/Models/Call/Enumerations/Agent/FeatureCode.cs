using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Enumerations.Agent
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FeatureCode
    {
        /// <summary>
        /// Non ACD (Feature Code 0)
        /// </summary>
        [JsonPropertyName("0")]
        NonACD = 0,

        /// <summary>
        /// Agent At Ready Out (Feature Code 2)
        /// </summary>
        [JsonPropertyName("2")]
        AgentAtReadyOut = 2,

        /// <summary>
        /// Manual (Feature Code 3)
        /// </summary>
        [JsonPropertyName("3")]
        Manual = 3,

        /// <summary>
        /// Agent At Ready In (Feature Code 6)
        /// </summary>
        [JsonPropertyName("6")]
        AgentAtReadyIn = 6,

        /// <summary>
        /// Agent Call Out (Feature Code 7)
        /// </summary>
        [JsonPropertyName("7")]
        AgentCallOut = 7,

        /// <summary>
        /// HCI (Feature Code 8)
        /// </summary>
        [JsonPropertyName("8")]
        HCI = 8,

        /// <summary>
        /// Strict HCI (Feature Code 9)
        /// </summary>
        [JsonPropertyName("9")]
        StrictHCI = 9
    }
}
