using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Compliance.Common;
using RestSharp;

namespace LiveVox.NET.Models.Compliance.Requests.DialtimeDNC
{
    public class SearchDialtimeDNCRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "campaign";
        [JsonIgnore]
        public string? Resource { get; set; } = "dialtime/dnc/search";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("count", Count.ToString());
            request.AddQueryParameter("offset", Offset.ToString());

            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }
        public SearchDialtimeDNCRequest(int count, int offset)
        {
            Count = count;
            Offset = offset;
        }
        /// <summary>
        /// Gets or sets the number of items to return in the list. There is a hard cap of 1000 items.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the offset from 0, based on the count, to start listing from.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets the DNC entries to create with the following structure.
        /// </summary>
        [JsonPropertyName("filter")]
        [Required]
        public DialtimeDNCEntry Filter { get; set; }
    }
}
