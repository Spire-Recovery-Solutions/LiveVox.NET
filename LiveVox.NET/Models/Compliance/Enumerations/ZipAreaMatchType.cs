using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Compliance.Enumerations
{
    public enum ZipAreaMatchType
    {
        /// <summary>
        /// Returns a true if the area code corresponds to the zip code within which it is normally located.
        /// </summary>
        [JsonPropertyName("DIAL_TIME")]
        DialTime,

        /// <summary>
        /// Returns a true if the area code corresponds to the zip code within which it is normally located
        /// OR if the area code and zip code for a record DO NOT correspond to each other but fall into the same time zone.
        /// </summary>
        [JsonPropertyName("DIAL_TIME_OPTIMIZED")]
        DialTimeOptimized
    }
}
