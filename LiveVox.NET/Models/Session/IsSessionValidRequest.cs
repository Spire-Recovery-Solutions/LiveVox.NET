using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Session
{
    public class IsSessionValidRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "session";
        public string? Resource { get; set; } = "validate";
        public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("sessionId", SessionId);
            return Task.FromResult(request);
        }
        public IsSessionValidRequest(string sessionId)
        {
            SessionId = sessionId;
        }

        public string SessionId { get; set; }

    }
}
