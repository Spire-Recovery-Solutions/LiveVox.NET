using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.IVR
{
    public class PauseCallRecordingRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "callControl/ivr/{serviceId}/{sessionId}/pause";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("serviceId", ServiceId);
            request.AddQueryParameter("sessionId", SessionId);
            return Task.FromResult(request);
        }
        public PauseCallRecordingRequest(int serviceId, string sessionId)
        {
            ServiceId = serviceId;
            SessionId = sessionId;
        }

        /// <summary>
        /// The service ID
        /// </summary>
        public int ServiceId { get; set; }

        /// <summary>
        /// The session ID of the call to pause
        /// </summary>
        public string SessionId { get; set; }
    }
}
