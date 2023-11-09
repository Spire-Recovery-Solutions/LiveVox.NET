using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Agent;

namespace LiveVox.NET.Models.Call.Responses.Agent.Voicemail
{
    public class CheckVoicemailResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets an array of voicemails.
        /// </summary>
        [JsonPropertyName("voiceMails")]
        public ICollection<VoicemailBox> VoiceMails { get; set; }
    }
}
