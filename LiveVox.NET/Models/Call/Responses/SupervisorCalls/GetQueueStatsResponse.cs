using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.SupervisorCalls;

namespace LiveVox.NET.Models.Call.Responses.SupervisorCalls
{
    public class GetQueueStatsResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the current number of agents available to handle calls from the queue.
        /// </summary>
        [JsonPropertyName("availableAgents")]
        public int AvailableAgents { get; set; }

        /// <summary>
        /// Gets or sets the current number of calls in the hold queue.
        /// (i.e., calls connected to a consumer and waiting to be transferred to an agent).
        /// </summary>
        [JsonPropertyName("callsOnHold")]
        public int CallsOnHold { get; set; }

        /// <summary>
        /// Gets or sets the current number of calls in the queue, waiting to be launched.
        /// </summary>
        [JsonPropertyName("callsToBeLaunched")]
        public int CallsToBeLaunched { get; set; }

        /// <summary>
        /// Gets or sets the current number of calls in progress (i.e., that have been launched).
        /// </summary>
        [JsonPropertyName("callsInProgress")]
        public int CallsInProgress { get; set; }

        /// <summary>
        /// Gets or sets the current number of agents logged into the queue (service).
        /// </summary>
        [JsonPropertyName("maxAgents")]
        public int MaxAgents { get; set; }
    }
}
