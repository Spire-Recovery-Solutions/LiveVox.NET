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
    public class GetAgentStatusRequest :  ILiveVoxRequest
    {
        [JsonIgnore] 
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/status";

        [JsonIgnore] 
        public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);

            request.AddQueryParameter("stateChangedAfter", StateChangedAfter);
            return Task.FromResult(request);
        }

        public GetAgentStatusRequest(DateTimeOffset stateChangedAfter)
        {
            StateChangedAfter = stateChangedAfter;
        }
        
        /// <summary>
        /// Timestamp to filter the 'agentStatus' objects.
        /// </summary>
        public DateTimeOffset StateChangedAfter { get; set; }
    }
}
