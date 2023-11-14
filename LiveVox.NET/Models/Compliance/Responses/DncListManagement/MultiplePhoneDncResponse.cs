using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Responses.DncListManagement
{
    public class MultiplePhoneDncResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the number of successfully created entries.
        /// </summary>
        [JsonPropertyName("successfulEntries")]
        public int SuccessfulEntries { get; set; }

        /// <summary>
        /// Gets or sets the number of entries that failed to be created.
        /// </summary>
        [JsonPropertyName("failedEntries")]
        public int FailedEntries { get; set; }

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

        /// <summary>
        /// Gets or sets the number of duplicate entries.
        /// </summary>
        [JsonPropertyName("duplicateEntries")]
        public int DuplicateEntries { get; set; }

    }
}
