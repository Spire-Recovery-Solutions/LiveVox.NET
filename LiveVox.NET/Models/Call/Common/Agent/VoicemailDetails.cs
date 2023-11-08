using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class VoicemailDetails
    {
        /// <summary>
        /// Indicates that agent voicemail call is connected.
        /// </summary>
        [JsonPropertyName("voicemailCallConnected")]
        public bool VoicemailCallConnected { get; set; }

        /// <summary>
        /// Error code for voicemail failure.
        /// </summary>
        [JsonPropertyName("voicemailFailureErrorCode")]
        public int VoicemailFailureErrorCode { get; set; }

        /// <summary>
        /// Reason for voicemail failure.
        /// </summary>
        [JsonPropertyName("voicemailFailureReson")]
        public string VoicemailFailureReason { get; set; }
    }
}
