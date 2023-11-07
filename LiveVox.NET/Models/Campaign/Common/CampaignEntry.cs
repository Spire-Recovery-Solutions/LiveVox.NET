using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Campaign.Enumerations;

namespace LiveVox.NET.Models.Campaign.Common
{
    public class CampaignEntry
    {
        /// <summary>
        /// Gets or sets the ID of the Campaign.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the Campaign.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of Campaign.
        /// Possible values: Outbound, Callback, Scheduled Callback, Manual, SMS.
        /// </summary>
        [JsonPropertyName("typeId")]
        public CampaignType TypeId { get; set; }

        /// <summary>
        /// Gets or sets the Service associated with the Campaign.
        /// </summary>
        [JsonPropertyName("serviceId")]
        public int ServiceId { get; set; }

        /// <summary>
        /// Gets or sets the status of the Campaign.
        /// Possible values: UNASSIGNED, ACTIVE, PREBUILT, PLAYING, PAUSED, STOPPED, COMPLETED, INVALID.
        /// </summary>
        [JsonPropertyName("status")]
        public CampaignStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the timestamp (Unix timestamp format) describing when the campaign was uploaded.
        /// </summary>
        [JsonPropertyName("uploadDate")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset UploadDate { get; set; }
    }
}
