using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Responses.DialingProfiles
{
    public class CreateDialingPolicyResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the ID of the newly created Dialing Policy.
        /// </summary>
        [JsonPropertyName("id")]
        public int PolicyId { get; set; }
    }
}
