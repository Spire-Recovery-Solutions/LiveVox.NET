using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Responses.DialtimeDNC
{
    public class CreateDialtimeDNCResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the ID for the created dialtime entry.
        /// </summary>
        [JsonPropertyName("id")]
        public int DialtimeId { get; set; }
    }
}
