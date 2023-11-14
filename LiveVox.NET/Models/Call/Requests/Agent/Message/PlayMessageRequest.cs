using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.Message
{
    public class PlayMessageRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore]
        public string? Resource { get; set; } = "agent/message/play";

        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);

            request.AddQueryParameter("agentMessageId", AgentMessageId);
            request.AddQueryParameter("messageId", MessageId);
            return Task.FromResult(request);
        }

        public PlayMessageRequest(int agentMessageId, int messageId)
        {
            AgentMessageId = agentMessageId;
            MessageId = messageId;
        }

        /// <summary>
        /// Agent Message ID.
        /// </summary>
        public int AgentMessageId { get; set; }

        /// <summary>
        /// Message ID.
        /// </summary>
        public int MessageId { get; set; }
    }
}
