using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Responses
{
    public class IsComplianceBlockedResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets a boolean value that indicates whether or not the call should be blocked.
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
