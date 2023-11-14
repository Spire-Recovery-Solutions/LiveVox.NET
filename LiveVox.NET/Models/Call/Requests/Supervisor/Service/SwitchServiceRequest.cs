using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Supervisor;
using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Supervisor.Service
{
    public class SwitchServiceRequest: ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "supervisor/agent/service/switch";

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
        /// An array of Agents that the supervisor wants to switch to a new Service.
        /// </summary>
        [JsonPropertyName("agents")]
        public ICollection<string> Agents { get; set; }

        /// <summary>
        /// The Service ID to which the Agents will be moved.
        /// </summary>
        [JsonPropertyName("targetServiceId")]
        public int TargetServiceId { get; set; }

        /// <summary>
        /// A message to send to the Agent.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
