using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Compliance.Common;

namespace LiveVox.NET.Models.Compliance.Responses.DialingProfiles
{
    public class ReadDialingProfileResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the ID of the client. The Client the Dialing Profile belongs to. If not included in the response, it means the Dialing Profile is a system-wide one that is available to all Clients.
        /// </summary>
        [JsonPropertyName("clientId")]
        public int? ClientId { get; set; }

        /// <summary>
        /// Gets or sets the display name of the Dialing Profile.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the Dialing Profile. Could be null.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this Dialing Profile is configured as the default Dialing Profile for the Client.
        /// </summary>
        [JsonPropertyName("clientDefault")]
        public bool ClientDefault { get; set; }

        /// <summary>
        /// Gets or sets an array of zero or more Services to which the Dialing Profile is assigned as the default.
        /// </summary>
        [JsonPropertyName("service")]
        public ICollection<ServiceEntry> Services { get; set; }

        /// <summary>
        /// Gets or sets the LiveVox ID of the Service.
        /// </summary>
        [JsonPropertyName("id")]
        public int ServiceId { get; set; }

        /// <summary>
        /// Gets or sets an array of zero or more policies that are configured for a Dialing Profile.
        /// </summary>
        [JsonPropertyName("policy")]
        [Required]
        public ICollection<DialingPolicy> Policies { get; set; }
    }
}
