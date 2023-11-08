using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.PreviewDial
{
    public class DialPreviewDialRequest : ILiveVoxRequest
    {
        [JsonIgnore] public string? Category { get; set; } = "callControl";

        [JsonIgnore] public string? Resource { get; set; } = "agent/customer/call/preview/dial";

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
        /// Transaction ID.
        /// </summary>
        [JsonPropertyName("transactionId")]
        public string TransactionId { get; set; }

        /// <summary>
        /// Number to dial.
        /// </summary>
        [JsonPropertyName("numberToDial")]
        public string NumberToDial { get; set; }
    }
}
