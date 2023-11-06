using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Common
{
    public class DaysDueEntry
    {
        /// <summary>
        /// Gets or sets the name of the DAYS_DUE field.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the value populating the DAYS_DUE field in the account transaction record.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
