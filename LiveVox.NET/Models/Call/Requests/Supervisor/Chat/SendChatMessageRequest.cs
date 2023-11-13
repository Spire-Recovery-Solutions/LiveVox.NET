using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Supervisor;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Supervisor.Chat
{
    public class SendChatMessageRequest: ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "supervisor/chat/send";

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
        /// ID of the user to be sent chat.
        /// </summary>
        [JsonPropertyName("userLoginId")]
        public string UserLoginId { get; set; }

        /// <summary>
        /// The message to be sent to the User.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

    }
}
