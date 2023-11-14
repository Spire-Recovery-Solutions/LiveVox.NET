using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Enumerations.Agent
{
    /// <summary>
    /// The schedule callback options available for a requested Service.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ScheduleCallbackOptions
    {
        /// <summary>
        /// Call only goes to the Agent who scheduled it.
        /// </summary>
        [JsonPropertyName("3")]
        OnlyToAgentWhoScheduledIt = 0,

        /// <summary>
        /// Call goes to the Agent, if available.
        /// If the Agent is unavailable it will be pooled in the Service (or DRG as set for the service) and go to the next available Agent.
        /// </summary>
        [JsonPropertyName("2")]
        IfAgentUnavailableGoToNext = 1,

        /// <summary>
        /// It will be pooled in the Service (or DRG as set for the service) and go to next available Agent.
        /// </summary>
        [JsonPropertyName("else")]
        PooledInTheService = 2,
    }
}
