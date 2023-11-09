using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.Voicemail
{
    public class DialVoicemailRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/voicemail/dial";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("id", Id);
            return Task.FromResult(request);
        }
        public DialVoicemailRequest(string id)
        {
            Id = id;
        }

        /// <summary>
        ///ID of the Voicemail box.
        /// </summary>
        public string Id { get; set; }
    }
}
