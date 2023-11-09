using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Call.Responses.Supervisor.AgentStatus
{
    public class ChangeToReadyResponse : ILiveVoxResponse
    {
        /// <summary>
        /// An array of Agent IDs and the result of the change request
        /// </summary>
        [JsonPropertyName("agents")]
        public ICollection<AgentsChangeRequestResult> Agents { get; set; }
    }

    public class AgentsChangeRequestResult
    {
        /// <summary>
        /// Agent login ID.
        /// </summary>
        [JsonPropertyName("agentLoginId")]
        public string AgentLoginId { get; set; }

        /// <summary>
        /// Indicates if the Agent status was changed to 'Ready'.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
