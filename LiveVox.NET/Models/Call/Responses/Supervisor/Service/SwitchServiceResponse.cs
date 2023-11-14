using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Call.Responses.Supervisor.Service
{
    public class SwitchServiceResponse : ILiveVoxResponse
    {
        /// <summary>
        /// An array of Agents and the result of the switch request
        /// </summary>
        [JsonPropertyName("agents")]
        public ICollection<Common.Supervisor.Agent> Agents { get; set; }
    }
}
