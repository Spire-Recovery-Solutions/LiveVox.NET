using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Compliance.Common;

namespace LiveVox.NET.Models.Compliance.Responses.DialtimeDnc
{
    public class SearchDialtimeDncResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets an array of Dialtime DNC entries that match the filter criteria in the request.
        /// </summary>
        [JsonPropertyName("dncEntries")]
        public ICollection<DialtimeDncEntry> DNCEntries { get; set; }
    }
}
