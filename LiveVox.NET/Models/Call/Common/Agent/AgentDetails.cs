using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class AgentDetails
    {
        /// <summary>
        /// Gets or sets the phone number of the Agent.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the wrap-up duration for the Agent.
        /// </summary>
        [JsonPropertyName("wrapup")]
        public string Wrapup { get; set; }

        /// <summary>
        /// Gets or sets the Login ID of the Agent.
        /// </summary>
        [JsonPropertyName("loginId")]
        public string LoginId { get; set; }

        /// <summary>
        /// Gets or sets an indicator if the Agent is active.
        /// </summary>
        [JsonPropertyName("active")]
        public string Active { get; set; }

        /// <summary>
        /// Gets or sets the Last name of the Agent.
        /// </summary>
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the First name of the Agent.
        /// </summary>
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets an indicator if the Agent is a home agent.
        /// </summary>
        [JsonPropertyName("homeAgent")]
        public string HomeAgent { get; set; }

        /// <summary>
        /// Gets or sets the ID of the Agent.
        /// </summary>
        [JsonPropertyName("agentId")]
        public string AgentId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the Call Center.
        /// </summary>
        [JsonPropertyName("callCenterId")]
        public int CallCenterId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the Service.
        /// </summary>
        [JsonPropertyName("serviceId")]
        public int ServiceId { get; set; }
    }
}
