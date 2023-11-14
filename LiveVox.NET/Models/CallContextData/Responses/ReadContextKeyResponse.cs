using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.CallContextData.Responses
{
    public class ReadContextKeyResponse : ILiveVoxResponse
    {
        /// <summary>
        /// The value associated to the supplied key
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
