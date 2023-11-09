using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Enumerations;

namespace LiveVox.NET.Models.Call.Responses.Routing
{
    public class GetRouteStatusResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the unique routing ID.
        /// </summary>
        [JsonPropertyName("routeUid")]
        public string RouteUid { get; set; }

        /// <summary>
        /// Gets or sets the route domain.
        /// </summary>
        [JsonPropertyName("routeDomain")]
        public string RouteDomain { get; set; }

        /// <summary>
        /// Gets or sets the agent session ID or Agent ID.
        /// </summary>
        [JsonPropertyName("endPointUid")]
        public string EndPointUid { get; set; }

        /// <summary>
        /// Gets or sets the wait time in the queue.
        /// </summary>
        [JsonPropertyName("estimatedWaitTime")]
        public int EstimatedWaitTime { get; set; }

        /// <summary>
        /// Gets or sets the current position of the call in the queue.
        /// </summary>
        [JsonPropertyName("positionInQueue")]
        public int PositionInQueue { get; set; }

        /// <summary>
        /// Gets or sets the total calls in the queue.
        /// </summary>
        [JsonPropertyName("queueSize")]
        public int QueueSize { get; set; }

        /// <summary>
        /// Gets or sets the current number of agents logged into the associated resource group.
        /// </summary>
        [JsonPropertyName("maxAgents")]
        public int MaxAgents { get; set; }

        /// <summary>
        /// Gets or sets the status of the call in the queue.
        /// Valid values: IN_QUEUE, NO_AGENT, AGENT_RESERVED.
        /// </summary>
        [JsonPropertyName("status")]
        public CallInQueueStatus Status { get; set; }
    }
}
