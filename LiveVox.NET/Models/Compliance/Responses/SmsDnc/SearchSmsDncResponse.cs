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
    public class SearchSmsDncResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets an array of SMS DNC entries that match the filter criteria in the request.
        /// </summary>
        [JsonPropertyName("dncEntries")]
        public ICollection<SmsDncEntry> DncEntries { get; set; }
    }
}
