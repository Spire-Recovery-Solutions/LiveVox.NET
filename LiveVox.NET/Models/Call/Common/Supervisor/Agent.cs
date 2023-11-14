using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Supervisor
{
    public class Agent
    {
        /// <summary>
        /// Agent ID.
        /// </summary>
        [JsonPropertyName("agentLoginId")]
        public string AgentLoginId { get; set; }

        /// <summary>
        /// Indicates if the Agent was successfully switched to the new Service
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
