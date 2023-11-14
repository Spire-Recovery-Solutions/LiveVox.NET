using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.CallContextData.Common;

namespace LiveVox.NET.Models.CallContextData.Responses
{
    public class ReadContextDataResponse : ILiveVoxResponse
    {
        /// <summary>
        /// The key value pairs associated with a Call.
        /// </summary>
        [JsonPropertyName("entry")]
        public ICollection<ContextDataEntry> Entries { get; set; }
    }
}
