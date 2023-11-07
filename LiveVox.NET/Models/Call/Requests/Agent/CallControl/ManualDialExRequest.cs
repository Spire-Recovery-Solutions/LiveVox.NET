using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.CallControl
{
    /// <summary>
    /// Used by an Agent to launch a manual call. This is a newer version of the Manual Dial method and allows a zip code to be included for zip area mismatch.
    /// In some cases, you might receive a 204 response but the call was not launched.
    /// In that case, you can check the agentManualDialingFailedErrorCode and agentManualDialingFailedReason for the reason why it was unsuccessful.
    /// These fields are available in the Get Agent Status API method.
    /// </summary>
    public class ManualDialExRequest : ILiveVoxRequest
    {
        [JsonIgnore] public string? Category { get; set; } = "callControl";

        [JsonIgnore] public string? Resource { get; set; } = "agent/customer/call/manual/ex";

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
        /// Phone number to be dialed.
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public long PhoneNumber { get; set; }

        /// <summary>
        /// Account number for the call.
        /// </summary>
        [JsonPropertyName("account")]
        public string? Account { get; set; }

        /// <summary>
        /// The zip code to be used for zip area mismatch.
        /// </summary>
        [JsonPropertyName("zipCode")]
        public string? ZipCode { get; set; }
    }
}
