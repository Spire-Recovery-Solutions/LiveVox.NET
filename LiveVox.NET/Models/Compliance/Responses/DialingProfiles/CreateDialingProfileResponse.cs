using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Responses.DialingProfiles
{
    public class CreateDialingProfileResponse : ILiveVoxResponse
    {
        /// <summary>
        /// The ID of the newly created Dialing Profile.
        /// </summary>
        [JsonPropertyName("id")]
        [Required]
        public int ProfileId { get; set; }
    }
}
