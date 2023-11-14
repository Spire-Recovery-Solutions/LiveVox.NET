using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Call.Common.Agent;

namespace LiveVox.NET.Models.Call.Common.Supervisor
{
    public class CallCenter
    {
        /// <summary>
        /// Gets or sets the ID of the Call Center.
        /// </summary>
        [JsonPropertyName("callCenterId")]
        public int CallCenterId { get; set; }

        /// <summary>
        /// Gets or sets the Name of the Call Center.
        /// </summary>
        [JsonPropertyName("callCenterName")]
        public string CallCenterName { get; set; }

        /// <summary>
        /// Gets or sets the array of services the supervisor has access to.
        /// </summary>
        [JsonPropertyName("services")]
        public ICollection<Service> Services { get; set; }
    }
}
