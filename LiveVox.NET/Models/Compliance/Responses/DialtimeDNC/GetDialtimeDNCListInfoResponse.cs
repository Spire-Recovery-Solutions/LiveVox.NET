using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Responses.DialtimeDnc
{
    public class GetDialtimeDncListInfoResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the number of Dialtime DNC entries currently loaded for that Client.
        /// </summary>
        [JsonPropertyName("size")]
        public int Size { get; set; }
    }
}
