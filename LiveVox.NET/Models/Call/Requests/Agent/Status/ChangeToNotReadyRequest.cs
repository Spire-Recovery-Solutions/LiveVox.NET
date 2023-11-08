using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.Status
{
    public class ChangeToNotReadyRequest :  ILiveVoxRequest
    {
        [JsonIgnore] 
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/status/notReady";

        [JsonIgnore] 
        public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);

            request.AddQueryParameter("reasonCode", ReasonCode);
            return Task.FromResult(request);
        }

        public ChangeToNotReadyRequest(string reasonCode)
        {
            ReasonCode = reasonCode;
        }
        
        /// <summary>
        /// The reason why an Agent was in Not Ready
        /// Enumeration : ReasonCode (in LiveVox.NET.Models.Call.Enumerations.Agent)
        /// </summary>
        public string ReasonCode { get; set; }
    }
}
