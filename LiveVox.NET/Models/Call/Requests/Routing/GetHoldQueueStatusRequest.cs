using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Routing
{
    public class GetHoldQueueStatusRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "routing/call/queue/stats";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("serviceId", ServiceId);
            
            return Task.FromResult(request);
        }
        public GetHoldQueueStatusRequest(int serviceId)
        {
            ServiceId = serviceId;
        }

        /// <summary>
        /// Service ID of the hold queue.
        /// </summary>
        public int ServiceId { get; set; }

    }
}
