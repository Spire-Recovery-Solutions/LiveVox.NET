using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Routing
{
    public class CallbackRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "routing/voice/route/callback";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("correlationId", CorrelationId);
            request.AddQueryParameter("customerNumber", CustomerNumber);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }
        public CallbackRequest(string correlationId, string customerNumber)
        {
            CorrelationId = correlationId;
            CustomerNumber = customerNumber;
        }

        /// <summary>
        /// Unique Identifier by Client
        /// </summary>
        public string CorrelationId { get; set; }

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
        /// Gets or sets the qualification data for the call details.
        /// </summary>
        [JsonPropertyName("qualificationData")]
        public string QualificationData { get; set; }

        /// <summary>
        /// Gets or sets the caller ID. It must match an inbound LiveVox service.
        /// </summary>
        [JsonPropertyName("callerId")]
        public string CallerId { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the callback.
        /// </summary>
        [JsonPropertyName("date")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Gets or sets the timezone of the callback date.
        /// Valid values: AT (Alaska Time), CT (Central Time), ET (Eastern Time), HI (Hawaiian),
        /// MT (Mountain Time), PT (Pacific Time), AL (Atlantic Time), GU (Guam Time).
        /// </summary>
        [JsonPropertyName("timezone")]
        public TimeZone Timezone { get; set; }
    }
}
