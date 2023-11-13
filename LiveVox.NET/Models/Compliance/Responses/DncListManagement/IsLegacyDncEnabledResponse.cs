using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Responses.DncListManagement
{
    public class IsLegacyDncEnabledResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the result indicating whether the Phone Type DNC is set to Legacy.
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
