using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Supervisor;

namespace LiveVox.NET.Models.Call.Responses.Supervisor.AgentStatus
{
    public class ChangeToNotReadyResponse : ILiveVoxResponse
    {
        /// <summary>
        /// An array of Agents and the result of the logoff request
        /// </summary>
        [JsonPropertyName("agents")]
        public ICollection<AgentsChangeRequestResult> Agents { get; set; }
    }

   
}
