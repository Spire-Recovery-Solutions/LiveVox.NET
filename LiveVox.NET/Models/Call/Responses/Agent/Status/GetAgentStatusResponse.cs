using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Agent;

namespace LiveVox.NET.Models.Call.Responses.Agent.Status
{
    public class GetAgentStatusResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets an object containing agent status.
        /// </summary>
        [JsonPropertyName("agentStatus")]
        public AgentStatusDetails AgentStatusDetails { get; set; }
    }
}
