using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Responses.SmsDnc
{
    public class CreateSmsDncResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the ID for the created entry.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
