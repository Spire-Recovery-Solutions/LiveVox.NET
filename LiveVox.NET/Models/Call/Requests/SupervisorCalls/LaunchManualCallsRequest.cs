using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Agent;
using LiveVox.NET.Models.Call.Common.SupervisorCalls;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.SupervisorCalls
{
    public class LaunchManualCallsRequest: ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "supervisor/calls/{serviceId}/LaunchManualCalls";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("serviceId", ServiceId);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }
        public LaunchManualCallsRequest(int serviceId)
        {
            ServiceId = serviceId;
        }

        /// <summary>
        /// The Service to launch the call on.
        /// </summary>
        public int ServiceId { get; set; }

        /// <summary>
        /// Provides information for each of the transactions requested to dial via the LaunchManualCalls API.
        /// </summary>
        [JsonPropertyName("callEntry")]
        public ICollection<SupervisorCallsCallEntry> CallEntries { get; set; }
    }
}
