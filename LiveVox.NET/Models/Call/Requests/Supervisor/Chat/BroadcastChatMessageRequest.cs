using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Supervisor;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Supervisor.Chat
{
    internal class BroadcastChatMessageRequest: ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "supervisor/chat/broadcast";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        /// <summary>
        /// An array of Agents to send chat message.
        /// </summary>
        [JsonPropertyName("usersInfo")]
        public ICollection<UsersInfo> UsersInfo { get; set; }

        /// <summary>
        /// A string containing a message to send to the Agent.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
