using LiveVox.NET.Models.Base;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Requests.Agent.Chat
{
    public class DeletePostRequest: ILiveVoxRequest
    {
        [JsonIgnore] 
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/chat/post";

        [JsonIgnore] 
        public Method RequestType { get; set; } = Method.Delete;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);

            request.AddQueryParameter("id", Id);
            return Task.FromResult(request);
        }

        public DeletePostRequest(string id)
        {
            Id = id;
        }

        /// <summary>
        /// The ID of the post.
        /// </summary>
        public string Id { get; set; }
    }
}
