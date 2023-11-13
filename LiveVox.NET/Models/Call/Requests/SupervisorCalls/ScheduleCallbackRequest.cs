using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Agent;
using LiveVox.NET.Models.Call.Common.SupervisorCalls;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.SupervisorCalls
{
    public class ScheduleCallbackRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore]
        public string? Resource { get; set; } = "supervisor/calls/{serviceId}/ScheduleCallback";

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
        public ScheduleCallbackRequest(int serviceId)
        {
            ServiceId = serviceId;
        }

        /// <summary>
        /// The Service to launch the call on.
        /// </summary>
        public int ServiceId { get; set; }

        /// <summary>
        /// Transaction ID.
        /// </summary>
        [JsonPropertyName("transactionId")]
        public int? TransactionId { get; set; }

        /// <summary>
        /// Phone number to dial
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        [Required]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Account number for the call
        /// </summary>
        [JsonPropertyName("account")]
        [Required]
        public string Account { get; set; }

        /// <summary>
        /// Agent Login ID
        /// </summary>
        [JsonPropertyName("agentLoginId")]
        public string AgentLoginId { get; set; }

        /// <summary>
        /// Date and Time to launch the call
        /// If date and time is not included, then the call will be scheduled immediately. 
        /// </summary>
        [JsonPropertyName("date")]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Phone number to dial
        /// </summary>
        [JsonPropertyName("timeZone")]
        public TimeZone TimeZone { get; set; }
    }
}
