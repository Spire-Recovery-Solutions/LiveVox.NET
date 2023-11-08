using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Responses
{
    public class ZipAreaMatchResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets a boolean value that returns true if the zip and area code "match"; otherwise, false is returned.
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
