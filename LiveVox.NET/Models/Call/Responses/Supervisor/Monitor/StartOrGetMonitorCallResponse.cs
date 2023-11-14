using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Call.Responses.Supervisor.Monitor
{
    public class StartOrGetMonitorCallResponse : ILiveVoxResponse
    {
        /// <summary>
        /// If true, the User currently has an audio path established for monitoring.
        /// </summary>
        [JsonPropertyName("activeCall")]
        public bool ActiveCall { get; set; }
    }
}
