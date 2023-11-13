using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Supervisor;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Supervisor.Chat
{
    public class TerminateChatSessionRequest: ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "supervisor/chat/end";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("userLoginId", UserLoginId);
            return Task.FromResult(request);
        }
        public TerminateChatSessionRequest(string userLoginId)
        {
            UserLoginId = userLoginId;
        }

        /// <summary>
        /// ID of the Agent to end the chat session for.
        /// </summary>
        public string UserLoginId { get; set; }


    }
}
