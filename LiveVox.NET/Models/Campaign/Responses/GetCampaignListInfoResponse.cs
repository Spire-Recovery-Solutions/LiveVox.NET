using LiveVox.NET.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Campaign.Responses
{
    public class GetCampaignListInfoResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the number of campaigns currently loaded for this client.
        /// </summary>
        [JsonPropertyName("size")]
        public int Size { get; set; }

        /// <summary>
        /// Gets or sets the most recently modified campaign's timestamp (Unix timestamp format).
        /// </summary>
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        [JsonPropertyName("lastModified")]
        public DateTimeOffset LastModified { get; set; }
    }
}
