using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.Service
{
    public class GetDetailsRequest: ILiveVoxRequest
    {
        [JsonIgnore] 
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/service/features";

        [JsonIgnore] 
        public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);

            request.AddQueryParameter("serviceId", ServiceId);
            return Task.FromResult(request);
        }

        public GetDetailsRequest(int serviceId)
        {
            ServiceId = serviceId;
        }

        /// <summary>
        /// ID of the Service which you want to retrieve the details for.
        /// </summary>
        public int ServiceId { get; set; }
    }
}
