using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Compliance.Common;

namespace LiveVox.NET.Models.Compliance.Responses.DncListManagement
{
    public class MultipleAccountDndResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the number of successfully created/updated entries.
        /// </summary>
        [JsonPropertyName("successfulEntries")]
        public int SuccessfulEntries { get; set; }

        /// <summary>
        /// Gets or sets the number of entries that failed to be created/updated.
        /// </summary>
        [JsonPropertyName("failedEntries")]
        public ICollection<FailedEntryDetails> FailedEntries { get; set; }

        /// <summary>
        /// Gets or sets the number of duplicate entries.
        /// </summary>
        [JsonPropertyName("duplicateEntries")]
        public int DuplicateEntries { get; set; }
    }
}
