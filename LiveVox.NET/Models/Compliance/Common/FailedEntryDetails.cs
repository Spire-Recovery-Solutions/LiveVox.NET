using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Compliance.Common
{
    public class FailedEntryDetails
    {
        /// <summary>
        /// Gets or sets the line of the entry that failed to be created.
        /// </summary>
        [JsonPropertyName("line")]
        public int? Line { get; set; }

        /// <summary>
        /// Gets or sets the reason why the entry failed.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
