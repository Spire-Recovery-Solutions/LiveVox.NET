using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Agent;

namespace LiveVox.NET.Models.Call.Responses.Agent.TransferAndConference
{
    public class GetAvailableAgentListResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Array of Agent details
        /// </summary>
        [JsonPropertyName("agentDetails")]
        public ICollection<AgentDetails> AgentDetails { get; set; } 
    }
}
