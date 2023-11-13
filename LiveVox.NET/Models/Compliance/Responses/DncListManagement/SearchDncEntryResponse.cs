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
    public class SearchDncEntryResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets a container for a page of DNC entries.
        /// </summary>
        [JsonPropertyName("dnc")]
        public ICollection<DncEntry> DncEntries { get; set; }

        /// <summary>
        /// Gets or sets a URI for the next page of entries. If next is not present or blank, then there are no pages after this one.
        /// </summary>
        [JsonPropertyName("next")]
        public Uri NextPageUri { get; set; }
    }
}
