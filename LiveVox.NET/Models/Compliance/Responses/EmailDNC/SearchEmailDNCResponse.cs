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
    public class SearchEmailDNCResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the array of Email DNC entries that match the filter criteria in the request.
        /// </summary>
        [JsonPropertyName("dncEntries")]
        [Required]
        public ICollection<EmailDNCEntry> DncEntries { get; set; }
    }
}
