using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Common
{
    public class CampaignFile
    {
        /// <summary>
        /// Gets or sets the campaign file name. It should match the campaign naming pattern of the input filter.
        /// </summary>
        [JsonPropertyName("FileName")]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the binary data of the campaign file.
        /// </summary>
        [JsonPropertyName("Data")]
        public byte[] Data { get; set; }

        /// <summary>
        /// Gets or sets the content type of the campaign file, e.g., "application/octet-stream".
        /// </summary>
        [JsonPropertyName("ContentType")]
        public string ContentType { get; set; }
    }
}