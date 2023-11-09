using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.TransferAndConference
{
    public class ManualTransferRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/conference/manual";

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
        public ManualTransferRequest(LineNumber lineNumber)
        {
            LineNumber = lineNumber;
        }

        /// <summary>
        /// The line of the call which the Agent is accepting
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LineNumber LineNumber { get; set; }

        /// <summary>
        /// Gets or sets the supervisor's phone number.
        /// </summary>
        [JsonPropertyName("supervisorNumber")]
        public string SupervisorNumber { get; set; }

        /// <summary>
        /// Gets or sets the extension of the person who will accept the transfer.
        /// </summary>
        [JsonPropertyName("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// Gets or sets the delay (in seconds) between dialing the 10-digit number and entering the extension.
        /// </summary>
        [JsonPropertyName("delayBeforeExtension")]
        public int DelayBeforeExtension { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the caller should be put on hold while the transfer is completed.
        /// </summary>
        [JsonPropertyName("putCallOnHold")]
        public bool PutCallOnHold { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the transfer is secure.
        /// </summary>
        [JsonPropertyName("secureTransfer")]
        public bool SecureTransfer { get; set; }
    }
}
