using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Compliance.Common;
using RestSharp;

namespace LiveVox.NET.Models.Compliance.Requests.DncListManagement
{
    public class SearchDncEntryRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "dnc/search";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            
            request.AddQueryParameter("client", ClientId.ToString());
            request.AddQueryParameter("count", Count.ToString());
            request.AddQueryParameter("Offset", Offset.ToString());
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        public SearchDncEntryRequest(int client, int count, int offset)
        {
            ClientId = client;
            Count = count;
            Offset = offset;
        }
        /// <summary>
        /// Gets or sets the Client ID to identify which Client the DNC list pertains to.
        /// </summary>
        public int? ClientId { get; set; }

        /// <summary>
        /// Gets or sets the number of items to return in the list. There is a hard cap of 1000 items.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the required offset for pagination. Specifies the offset from 0, based on the count, to start listing from.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets the criteria for DNC search.
        /// </summary>
        [JsonPropertyName("type")]
        public DncSearchCriteria Type { get; set; }
    }
}
