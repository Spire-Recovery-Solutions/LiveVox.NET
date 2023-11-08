using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class Service
    {
        /// <summary>
        /// Gets or sets the ID of the Service.
        /// </summary>
        [JsonPropertyName("serviceId")]
        public int ServiceId { get; set; }

        /// <summary>
        /// Gets or sets the name of the Service.
        /// </summary>
        [JsonPropertyName("serviceName")]
        public string ServiceName { get; set; }
    }
}
