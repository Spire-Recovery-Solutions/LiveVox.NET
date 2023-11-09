using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Routing
{
    public class RouteToAgentRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "routing/voice/route";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Put;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("correlationId", CorrelationId);
            request.AddQueryParameter("dialedNumber", DialedNumber);
            request.AddQueryParameter("customerNumber", CustomerNumber);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }
        public RouteToAgentRequest(string correlationId, string dialedNumber, string customerNumber)
        {
            CorrelationId = correlationId;
            DialedNumber = dialedNumber;
            CustomerNumber = customerNumber;
        }

        /// <summary>
        /// Unique Identifier by Client
        /// </summary>
        public string CorrelationId { get; set; }

        /// <summary>
        /// Number dialed by Customer
        /// </summary>
        public string DialedNumber { get; set; }

        /// <summary>
        /// Customer's phone number
        /// </summary>
        public string CustomerNumber { get; set; }

        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the JSON object for the call details.
        /// </summary>
        [JsonPropertyName("qualificationData")]
        public string QualificationData { get; set; }

        /// <summary>
        /// Gets or sets the agent skill required to handle the call.
        /// </summary>
        [JsonPropertyName("agentSkill")]
        public string AgentSkill { get; set; }

        /// <summary>
        /// Gets or sets the priority of the call.
        /// </summary>
        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        /// <summary>
        /// Gets or sets the amount of time an agent will be reserved before being put back into 'Ready' if the call doesn't arrive.
        /// </summary>
        [JsonPropertyName("reservationTime")]
        public int ReservationTime { get; set; }
    }
}
