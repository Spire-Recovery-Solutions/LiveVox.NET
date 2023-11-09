using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Responses.DialingProfiles
{
    public class GetDialingProfileListInfoResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the total number of entries in the list.
        /// </summary>
        [JsonPropertyName("size")]
        public int Size { get; set; }

        /// <summary>
        /// Gets or sets the last date & time that the list was updated. This information might not be available.
        /// </summary>
        [JsonPropertyName("lastModified")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset? LastModified { get; set; }
    }
}
