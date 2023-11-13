using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Compliance.Common
{
    public class DialingProfile
    {
        /// <summary>
        /// Gets or sets the internal LiveVox ID of the Dialing Profile.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the display name of the Dialing Profile.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the Dialing Profile.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
