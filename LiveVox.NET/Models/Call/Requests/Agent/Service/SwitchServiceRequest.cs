using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.Service
{
    public class SwitchServiceRequest: ILiveVoxRequest
    {
        [JsonIgnore] 
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/service/switch";

        [JsonIgnore] 
        public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);

            request.AddQueryParameter("serviceId", ServiceId);
            return Task.FromResult(request);
        }

        public SwitchServiceRequest(int serviceId)
        {
            ServiceId = serviceId;
        }

        /// <summary>
        /// ID of the Service the Agent wants to switch to.
        /// </summary>
        public int ServiceId { get; set; }
    }
}
