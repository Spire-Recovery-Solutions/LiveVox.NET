using LiveVox.NET.Models.Base;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using LiveVox.NET.Models.Call.Enumerations.Agent;

namespace LiveVox.NET.Models.Call.Requests.Supervisor.AgentStatus
{
    public class ChangeToNotReadyRequest: ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "supervisor/agent/status/notready";

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
        /// An array of Agent login IDs which needs to be changed to the 'NotReady' state.
        /// </summary>
        [JsonPropertyName("agents")]
        public ICollection<string> Agents { get; set; }

        /// <summary>
        ///The reason for being in 'Not Ready', 
        /// </summary>
        [JsonPropertyName("reasonCode")]
        public ReasonCode ReasonCode { get; set; }

        /// <summary>
        /// A string containing a message to send to the Agent.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
