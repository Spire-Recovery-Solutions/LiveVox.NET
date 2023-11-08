using LiveVox.NET.Converter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Common
{
    public class DateRange
    {
        
        /// <summary>
        /// Gets or sets the starting date/time of the range in which to search for Campaigns.
        /// </summary>
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        [JsonPropertyName("from")]
        [Required]
        public DateTimeOffset From { get; set; }

        /// <summary>
        /// Gets or sets the ending date/time of the range in which to search for Campaigns.
        /// </summary>
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        [JsonPropertyName("to")]
        [Required]
        public DateTimeOffset To { get; set; }
    }
}
