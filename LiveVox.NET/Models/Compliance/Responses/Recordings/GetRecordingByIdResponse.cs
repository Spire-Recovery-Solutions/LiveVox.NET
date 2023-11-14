using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Responses.Recordings
{
    public class GetRecordingByIdResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the binary data representing the call recording (MP3).
        /// </summary>
        [JsonPropertyName("binaryData")]
        public byte[] BinaryData { get; set; }
    }
}
