using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Compliance.Common;

namespace LiveVox.NET.Models.Compliance.Responses.DialingProfiles
{
    public class ListDialingProfileResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets a container for a page of Dialing Profile entries.
        /// </summary>
        [JsonPropertyName("dialingProfile")]
        public ICollection<DialingProfile> DialingProfiles { get; set; }

        /// <summary>
        /// Gets or sets the URI for the next page of entries. If next is not present or blank, then there are no pages after this one.
        /// </summary>
        [JsonPropertyName("next")]
        public Uri Next { get; set; }
    }
}
