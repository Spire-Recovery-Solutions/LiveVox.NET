using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Responses.SmsDnc
{
    public class GetSmsDncListInfoResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the number of SMS DNC entries currently loaded for that client.
        /// </summary>
        [JsonPropertyName("size")]
        public int Size { get; set; }
    }
}
