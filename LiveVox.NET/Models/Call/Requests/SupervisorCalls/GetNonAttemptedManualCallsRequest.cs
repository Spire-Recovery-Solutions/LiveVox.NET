using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Agent;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.SupervisorCalls
{
    public class GetNonAttemptedManualCallsRequest: ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "supervisor/calls/{serviceId}/GetNonAttemptedManualCalls";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("serviceId", ServiceId);
            return Task.FromResult(request);
        }
        public GetNonAttemptedManualCallsRequest(int serviceId)
        {
            ServiceId = serviceId;
        }

        /// <summary>
        /// The Service to search for non-attempted manual calls
        /// </summary>
        public int ServiceId { get; set; }


    }
}
