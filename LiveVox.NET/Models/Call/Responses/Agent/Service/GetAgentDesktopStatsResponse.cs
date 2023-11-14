using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Agent;

namespace LiveVox.NET.Models.Call.Responses.Agent.Service
{
    public class GetAgentDesktopStatsResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Available agents.
        /// </summary>
        [JsonPropertyName("availableAgents")]
        public long AvailableAgents { get; set; }

        /// <summary>
        /// Calls on hold.
        /// </summary>
        [JsonPropertyName("callsOnHold")]
        public int CallsOnHold { get; set; }

        /// <summary>
        /// Calls remaining.
        /// </summary>
        [JsonPropertyName("remaining")]
        public int Remaining { get; set; }

        /// <summary>
        /// Calls In Progress.
        /// </summary>
        [JsonPropertyName("cip")]
        public int CallsInProgress { get; set; }

        /// <summary>
        /// Total Agents.
        /// </summary>
        [JsonPropertyName("totalAgents")]
        public int TotalAgents { get; set; }

        /// <summary>
        /// Maximum calls on hold.
        /// </summary>
        [JsonPropertyName("maxCallsOnHold")]
        public int MaxCallsOnHold { get; set; }

        /// <summary>
        /// Maximum calls in progress.
        /// </summary>
        [JsonPropertyName("maxCallsInProgress")]
        public int MaxCallsInProgress { get; set; }

        /// <summary>
        /// Records loaded.
        /// </summary>
        [JsonPropertyName("loaded")]
        public int RecordsLoaded { get; set; }

        /// <summary>
        /// Size of HCI queue.
        /// </summary>
        [JsonPropertyName("hciQueueSize")]
        public int HciQueueSize { get; set; }

        /// <summary>
        /// Hold graph data
        /// </summary>
        [JsonPropertyName("holdGraphData")]
        public HoldGraphData HoldGraphData{ get; set; }

        /// <summary>
        /// Agent average graph data 
        /// </summary>
        [JsonPropertyName("agentAverageGraphData")]
        public AgentAverageGraphData AgentAverageGraphData { get; set; }
    }
}
