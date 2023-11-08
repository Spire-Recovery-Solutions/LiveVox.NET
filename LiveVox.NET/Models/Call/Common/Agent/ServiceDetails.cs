using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class ServiceDetails
    {
        /// <summary>
        /// Total calls in progress for the Service.
        /// </summary>
        [JsonPropertyName("callsInProgress")]
        public int CallsInProgress { get; set; }

        /// <summary>
        /// Total calls remaining for the Service.
        /// </summary>
        [JsonPropertyName("callsRemaining")]
        public int CallsRemaining { get; set; }

        /// <summary>
        /// Total calls currently on hold for the Service.
        /// </summary>
        [JsonPropertyName("callsOnHold")]
        public int CallsOnHold { get; set; }

        /// <summary>
        /// Indicates if switch Service is initiated.
        /// </summary>
        [JsonPropertyName("reloadServiceFeatures")]
        public bool ReloadServiceFeatures { get; set; }

        /// <summary>
        /// New Service ID after a switch Service action by Agent/Supervisor.
        /// </summary>
        [JsonPropertyName("reloadServiceId")]
        public int ReloadServiceId { get; set; }
    }
}
