using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Agent;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.SupervisorCalls
{
    public class GetQueueStatsRequest: ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "supervisor/calls/queue";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("serviceId", ServiceId);
            return Task.FromResult(request);
        }
        public GetQueueStatsRequest(int serviceId)
        {
            ServiceId = serviceId;
        }

        /// <summary>
        /// The Service ID to retrieve queue stats for
        /// </summary>
        public int ServiceId { get; set; }


    }
}
