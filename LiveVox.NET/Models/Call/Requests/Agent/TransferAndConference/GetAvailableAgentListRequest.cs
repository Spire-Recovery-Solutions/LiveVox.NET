using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Agent;
using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.TransferAndConference
{
    public class GetAvailableAgentListRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/available";

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
        /// Array of Call Centers in which to search for available Agents.
        /// </summary>
        [JsonPropertyName("callCenter")]
        public ICollection<CallCenter> CallCenters { get; set; }
    }
}
