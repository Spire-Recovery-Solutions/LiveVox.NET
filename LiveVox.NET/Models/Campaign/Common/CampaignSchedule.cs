using LiveVox.NET.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Common
{
    public class CampaignSchedule
    {
        /// <summary>
        /// Gets or sets the start date and time of the campaign.
        /// </summary>
        [JsonPropertyName("start")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset Start { get; set; }

        /// <summary>
        /// Gets or sets the end date and time of the campaign.
        /// </summary>
        [JsonPropertyName("end")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset End { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating if the campaign should run on the following day.
        /// </summary>
        [JsonPropertyName("nextDay")]
        public bool NextDay { get; set; }
    }
}