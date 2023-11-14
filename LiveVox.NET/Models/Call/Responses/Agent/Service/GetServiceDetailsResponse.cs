using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Call.Responses.Agent.Service
{
    public class GetServiceDetailsResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets an indicator if the Agent is a home agent.
        /// </summary>
        [JsonPropertyName("homeAgent")]
        public bool HomeAgent { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the Agent.
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets an array of Services the Agent has access to.
        /// </summary>
        [JsonPropertyName("services")]
        public List<Common.Agent.Service> Services { get; set; }

        /// <summary>
        /// Gets or sets the SIP ID for the Agent.
        /// </summary>
        [JsonPropertyName("sipId")]
        public string SipId { get; set; }
    }
}
