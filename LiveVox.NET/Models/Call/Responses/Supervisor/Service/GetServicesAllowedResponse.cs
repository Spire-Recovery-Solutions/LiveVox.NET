using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Supervisor;

namespace LiveVox.NET.Models.Call.Responses.Supervisor.Service
{
    public class GetServicesAllowedResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Array of Call Centers and Services the supervisor has access to.
        /// </summary>
        [JsonPropertyName("callCenters")]
        public ICollection<CallCenter> CallCenters { get; set; }
    }
}
