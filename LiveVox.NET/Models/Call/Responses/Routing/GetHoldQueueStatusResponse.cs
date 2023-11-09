using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Call.Responses.Routing
{
    public class GetHoldQueueStatusResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the estimated wait time for a call in the queue in seconds.
        /// </summary>
        [JsonPropertyName("estimatedWaitTime")]
        public int EstimatedWaitTime { get; set; }

        /// <summary>
        /// Gets or sets the total number of calls in the queue.
        /// </summary>
        [JsonPropertyName("callsInQueue")]
        public int CallsInQueue { get; set; }
    }
}
