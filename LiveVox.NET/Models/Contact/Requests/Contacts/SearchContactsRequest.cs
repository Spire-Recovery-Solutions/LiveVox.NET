using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Contact.Common;
using LiveVox.NET.Models.Contact.Common.Contacts;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests.Contacts
{
    public class SearchContactsRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "contact";
        [JsonIgnore]
        public string? Resource { get; set; } = "contacts/search";
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
        public SearchContactsRequest(int count, int offset)
        {
            Count = count;
            Offset = offset;
        }

        /// <summary>
        /// Specifies the number of items to return in the list. There is a hard cap of 1000 items.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Required for pagination. Specifies the offset from 0, based on the count, to start listing from.
        /// </summary>
        public int Offset { get; set; }

        // Properties to hold the request data
        /// <summary>
        /// Filter criteria for the request. There are two types of branches for the filter, a rule, and a condition;
        /// a filter can start with either, however, if you want to search by multiple criteria you'll need to start the search with a rule.
        /// </summary>
        [Required]
        [JsonPropertyName("search")]
        public object Search { get; set; }

        /// <summary>
        /// The sort order of the returned contacts.
        /// </summary>
        [JsonPropertyName("sort")]
        public ICollection<Sort> Sort { get; set; }
        
    }
}
