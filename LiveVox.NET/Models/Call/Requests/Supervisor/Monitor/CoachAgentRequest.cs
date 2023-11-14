using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Supervisor.Monitor
{
    public class CoachAgentRequest: ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "supervisor/monitor/coach";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("agentLoginId", AgentLoginId);
            return Task.FromResult(request);
        }
        public CoachAgentRequest(string agentLoginId)
        {
            AgentLoginId = agentLoginId;
        }

        /// <summary>
        /// ID of the Agent to being coaching.
        /// </summary>
        public string AgentLoginId { get; set; }


    }
}
