using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ScrubOption
    {
        /// <summary>
        /// No scrubbing occurs.
        /// </summary>
        [JsonPropertyName("NONE")]
        NONE,

        /// <summary>
        /// Scrubs all wireless phone numbers so that all landline numbers can be dialed.
        /// </summary>
        [JsonPropertyName("WIRELESS")]
        WIRELESS,

        /// <summary>
        /// Scrubs all landline numbers so that all wireless phone numbers can be dialed.
        /// </summary>
        [JsonPropertyName("LANDLINE")]
        LANDLINE,

        /// <summary>
        /// Scrubs all wireless phone numbers from positions 1-15 and places them starting at position 16.
        /// </summary>
        [JsonPropertyName("SEGMENTED_WIRELESS")]
        SEGMENTED_WIRELESS
    }
}
