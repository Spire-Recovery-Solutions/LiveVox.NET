using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Responses.EmailDNC
{
    public class GetEmailDNCListInfoResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the number of Email DNC entries currently loaded for that client.
        /// </summary>
        [JsonPropertyName("size")]
        [Required]
        public int Size { get; set; }
    }
}
