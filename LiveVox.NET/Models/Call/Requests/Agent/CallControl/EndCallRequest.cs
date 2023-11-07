using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Requests.Agent.CallControl
{
    internal class EndCallRequest: ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/customer/call/end";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("lineNumber", LineNumber);
            return Task.FromResult(request);
        }
        public EndCallRequest(LineNumber lineNumber)
        {
            LineNumber = lineNumber;
        }

        /// <summary>
        /// The line of the call which the Agent is ending
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LineNumber LineNumber { get; set; }
    }
}
