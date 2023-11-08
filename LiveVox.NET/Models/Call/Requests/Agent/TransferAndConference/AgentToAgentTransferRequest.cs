using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.TransferAndConference
{
    public class AgentToAgentTransferRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/conference/agent";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("lineNumber", LineNumber);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }
        public AgentToAgentTransferRequest(LineNumber lineNumber)
        {
            LineNumber = lineNumber;
        }

        /// <summary>
        /// The line of the call which the Agent is accepting
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LineNumber LineNumber { get; set; }

        /// <summary>
        /// Target Agent logon ID.
        /// </summary>
        [JsonPropertyName("secondAgentLoginId")]
        public string SecondAgentLoginId { get; set; }

        /// <summary>
        /// Call center ID (blank would be all call centers).
        /// </summary>
        [JsonPropertyName("callCenterId")]
        public int CallCenterId { get; set; }
    }
}
