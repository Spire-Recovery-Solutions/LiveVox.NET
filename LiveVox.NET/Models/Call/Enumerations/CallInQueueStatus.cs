using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CallInQueueStatus
    {
        /// <summary>
        /// Call is waiting in the queue for an Agent.
        /// </summary>
        [JsonPropertyName("IN_QUEUE")]
        IN_QUEUE = 1,

        /// <summary>
        /// No Agents are currently logged into the queue.
        /// </summary>
        [JsonPropertyName("NO_AGENT")]
        NO_AGENT = 2,

        /// <summary>
        /// Agent has been reserved, and the call is being transferred.
        /// </summary>
        [JsonPropertyName("AGENT_RESERVED")]
        AGENT_RESERVED = 3,
    }
}
