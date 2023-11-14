using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Responses.DialtimeDnc
{
    public class CreateMultipleDialtimeDncResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the number of records processed.
        /// </summary>
        [JsonPropertyName("processedCount")]
        public int ProcessedCount { get; set; }
    }
}
