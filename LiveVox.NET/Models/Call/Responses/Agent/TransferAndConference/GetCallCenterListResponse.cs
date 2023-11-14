using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Agent;

namespace LiveVox.NET.Models.Call.Responses.Agent.TransferAndConference
{
    public class GetCallCenterListResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Array of call centers
        /// </summary>
        [JsonPropertyName("callCenterList")]
        public ICollection<AgentCallCenter> CallCenterList { get; set; }
    }
}
