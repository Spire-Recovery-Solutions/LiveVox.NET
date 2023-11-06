using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Common
{
    public class ExtraEntry
    {
        /// <summary>
        /// Gets or sets the name of the EXTRA field (e.g. EXTRA_14).
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the value populating the EXTRA field in the account transaction record.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
