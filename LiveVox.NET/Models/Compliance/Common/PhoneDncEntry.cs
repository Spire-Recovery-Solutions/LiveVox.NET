using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Compliance.Common
{
    public class PhoneDncEntry
    {
        /// <summary>
        /// Gets or sets the phone number to create/update.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets an array of services on which the phone number will be blocked.
        /// </summary>
        [JsonPropertyName("service")]
        public ICollection<ServiceEntry> Services { get; set; }
    }
}
