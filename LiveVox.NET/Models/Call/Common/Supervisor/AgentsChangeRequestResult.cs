using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Supervisor
{
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
