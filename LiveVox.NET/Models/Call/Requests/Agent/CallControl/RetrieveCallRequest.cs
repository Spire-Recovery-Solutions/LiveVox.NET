using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.CallControl
{
    /// <summary>
    /// Used by an Agent to retrieve a call on hold.
    /// </summary>
    public class RetrieveCallRequest : ILiveVoxRequest
    {
        [JsonIgnore] public string? Category { get; set; } = "callControl";

        [JsonIgnore] public string? Resource { get; set; } = "agent/customer/call/unhold";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("lineNumber", LineNumber);
            return Task.FromResult(request);
        }

        public RetrieveCallRequest(LineNumber lineNumber)
        {
            LineNumber = lineNumber;
        }

        /// <summary>
        /// The line of the call which the Agent is retrieving
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LineNumber LineNumber { get; set; }

    }
}
