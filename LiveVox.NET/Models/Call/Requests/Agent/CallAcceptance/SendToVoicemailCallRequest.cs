using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.CallAcceptance
{
    public class SendToVoicemailCallRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/customer/call/sendToVoiceMail";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("lineNumber", LineNumber);
            return Task.FromResult(request);
        }
        public SendToVoicemailCallRequest(LineNumber lineNumber)
        {
            LineNumber = lineNumber;
        }

        /// <summary>
        /// The line of the call which the Agent is sending to voicemai
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LineNumber LineNumber { get; set; }
    }
}
