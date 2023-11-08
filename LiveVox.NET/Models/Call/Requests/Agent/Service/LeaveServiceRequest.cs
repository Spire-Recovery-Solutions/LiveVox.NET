using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.Service
{
    public class LeaveServiceRequest: ILiveVoxRequest
    {
        [JsonIgnore] 
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/service/leave";

        [JsonIgnore] 
        public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);

            return Task.FromResult(request);
        }

    }
}
