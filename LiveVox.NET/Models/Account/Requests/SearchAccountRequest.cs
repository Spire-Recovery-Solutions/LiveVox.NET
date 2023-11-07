using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Account.Common;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Account.Requests
{
    public class SearchAccountRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "account";
        [JsonIgnore]
        public string? Resource { get; set; } = "accounts/search";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Post;
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("count", Count);
            request.AddQueryParameter("offset", Offset);

           // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }
        public SearchAccountRequest(int count, int offset)
        {
            Count = count;
            Offset = offset;
        }

        /// <summary>
        /// Gets or sets the number of items to return in the list. There is a hard cap of 1000 items.
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the offset from 0, based on the count, to start listing from.
        /// </summary>
        [JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets an object specifying the search criteria.
        /// </summary>
        [JsonPropertyName("search")]
        public SearchCriteria SearchCriteria { get; set; }
    }
}
