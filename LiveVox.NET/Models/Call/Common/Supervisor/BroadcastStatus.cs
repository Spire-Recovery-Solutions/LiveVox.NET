using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Supervisor
{
    public class BroadcastStatus
    {
        /// <summary>
        /// Gets or sets the Agent ID.
        /// </summary>
        [JsonPropertyName("userLoginId")]
        public string UserLoginId { get; set; }

        /// <summary>
        /// Gets or sets a boolean indicating if the message was sent to the Agent.
        /// </summary>
        [JsonPropertyName("sent")]
        [JsonRequired]
        public bool Sent { get; set; }
    }
}
