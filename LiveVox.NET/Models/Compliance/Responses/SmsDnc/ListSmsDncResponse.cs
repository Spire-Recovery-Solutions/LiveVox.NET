using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Compliance.Common;

namespace LiveVox.NET.Models.Compliance.Responses.SmsDnc
{
    public class ListSmsDncResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets a URI for the next page of entries. If next is not present, or blank, then there are no pages after this one.
        /// </summary>
        [JsonPropertyName("next")]
        public Uri Next { get; set; }

        /// <summary>
        /// Gets or sets a container for a page of SMS DNC entries. The page size is controlled using count and offset in the request.
        /// </summary>
        [JsonPropertyName("dncEntries")]
        public ICollection<SmsDncEntry> DncEntries { get; set; }
    }
}
