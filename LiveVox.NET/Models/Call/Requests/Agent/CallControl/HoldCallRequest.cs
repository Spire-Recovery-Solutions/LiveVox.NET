using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Call.Requests.Agent.CallControl
{
    public class HoldCallRequest : ILiveVoxRequest
    {
        [JsonIgnore] public string? Category { get; set; } = "callControl";

        [JsonIgnore] public string? Resource { get; set; } = "agent/customer/call/hold";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("lineNumber", LineNumber);
            return Task.FromResult(request);
        }

        public HoldCallRequest(LineNumber lineNumber)
        {
            LineNumber = lineNumber;
        }

        /// <summary>
        /// The line of the call which the Agent is placing on hold
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LineNumber LineNumber { get; set; }
    }
}
