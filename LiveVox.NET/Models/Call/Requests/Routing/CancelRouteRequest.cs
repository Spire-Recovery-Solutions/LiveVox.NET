using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Routing
{
    public class CancelRouteRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "routing/voice/route";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Delete;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("correlationId", CorrelationId);
            request.AddQueryParameter("dialedNumber", DialedNumber);
            request.AddQueryParameter("customerNumber", CustomerNumber);
            
            return Task.FromResult(request);
        }
        public CancelRouteRequest(string correlationId, string dialedNumber, string customerNumber)
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

        
    }
}
