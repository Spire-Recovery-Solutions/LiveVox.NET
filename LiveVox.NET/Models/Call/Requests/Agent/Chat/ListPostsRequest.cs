using LiveVox.NET.Models.Base;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Requests.Agent.Chat
{
    public class ListPostsRequest: ILiveVoxRequest
    {
        [JsonIgnore] 
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/chat/channel/{id}?page={n}";

        [JsonIgnore] 
        public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);

            request.AddQueryParameter("id", Id);
            request.AddQueryParameter("n", Page);
            return Task.FromResult(request);
        }

        public ListPostsRequest(string id, int page)
        {
            Id = id;
        }

        /// <summary>
        /// Channel ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The page number. Your first request for posts must have a page number of 0 and subsequent requests must proceed in ascending order.
        /// That is, your second request must have a page of 1, 3rd request a page of 2 and so on.
        /// Alternatively, you can make your first request and then use the 'next' property in the response to get to the next page.
        /// </summary>
        public int Page { get; set; }
    
    }
}
