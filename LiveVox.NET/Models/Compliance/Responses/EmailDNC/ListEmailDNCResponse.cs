using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Compliance.Common;

namespace LiveVox.NET.Models.Compliance.Responses.EmailDNC
{
    public class ListEmailDNCResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the URI for the next page of entries. If not present or blank, there are no pages after this one.
        /// </summary>
        [JsonPropertyName("next")]
        [Required]
        public Uri Next { get; set; }

        /// <summary>
        /// Gets or sets a container for a page of Email DNC entries.
        /// </summary>
        [JsonPropertyName("dncEntries")]
        [Required]
        public ICollection<EmailDNCEntry> DncEntries { get; set; }
    }
}
