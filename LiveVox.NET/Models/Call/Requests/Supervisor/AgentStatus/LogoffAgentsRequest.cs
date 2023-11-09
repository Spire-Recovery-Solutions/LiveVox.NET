using LiveVox.NET.Models.Base;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Requests.Supervisor.AgentStatus
{
    internal class LogoffAgentsRequest: ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "supervisor/agent/status/logoff";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        /// <summary>
        /// An array of Agent login IDs which needs to be changed to the 'Ready' state.
        /// </summary>
        [JsonPropertyName("agents")]
        public ICollection<string> Agents { get; set; }

        /// <summary>
        /// A string containing a message to send to the Agent.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
