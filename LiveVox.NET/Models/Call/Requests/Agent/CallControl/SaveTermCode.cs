using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.CallControl
{
    public class SaveTermCode : ILiveVoxRequest
    {
        [JsonIgnore] public string? Category { get; set; } = "callControl";

        [JsonIgnore] public string? Resource { get; set; } = "agent/call/termCode";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Put;

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

        public SaveTermCode(LineNumber lineNumber)
        {
            LineNumber = lineNumber;
        }

        /// <summary>
        /// The line of the call which the Agent is retrieving
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LineNumber LineNumber { get; set; }

        /// <summary>
        /// Service ID.
        /// </summary>
        [JsonPropertyName("serviceId")]
        public int ServiceId { get; set; }

        /// <summary>
        /// Call Transaction ID.
        /// </summary>
        [JsonPropertyName("callTransactionId")]
        [Required]
        public int CallTransactionId { get; set; }

        /// <summary>
        /// Call Session ID.
        /// </summary>
        [JsonPropertyName("callSessionId")]
        [Required]
        public string CallSessionId { get; set; }

        /// <summary>
        /// Term Code ID.
        /// </summary>
        [JsonPropertyName("termCodeId")]
        [Required]
        public string TermCodeId { get; set; }

        /// <summary>
        /// Payment amount.
        /// </summary>
        [JsonPropertyName("paymentAmt")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// Account number.
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Agent entered account number.
        /// </summary>
        [JsonPropertyName("agentEnteredAccount")]
        public string AgentEnteredAccount { get; set; }

        /// <summary>
        /// Notes.
        /// </summary>
        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Phone dialed.
        /// </summary>
        [JsonPropertyName("phoneDialed")]
        [Required]
        public string PhoneDialed { get; set; }

        /// <summary>
        /// Whether the agent should be moved to the not ready state after saving the termination code.
        /// </summary>
        [JsonPropertyName("moveAgentToNotReady")]
        [Required]
        public bool MoveAgentToNotReady { get; set; }

        /// <summary>
        /// Reason code.
        /// </summary>
        [JsonPropertyName("reasonCode")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ReasonCode ReasonCode { get; set; }

        /// <summary>
        /// Immediate callback dialing number.
        /// </summary>
        [JsonPropertyName("immediateCallbackNumber")]
        public int ImmediateCallbackNumber { get; set; }
    }
}
