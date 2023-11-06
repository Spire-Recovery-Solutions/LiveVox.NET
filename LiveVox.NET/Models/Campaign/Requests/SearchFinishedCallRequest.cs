using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Campaign.Requests
{
    public class SearchFinishedCallRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "campaign";
        public string? Resource { get; set; } = "campaigns";
        public string? FinishedCalls { get; set; } = "finishedCalls";
        public Method RequestType { get; set; }

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest($"{Category}/{Resource}/{CampaignId}/{FinishedCalls}", RequestType);

            // Add query parameters for count and offset
            request.AddQueryParameter("count", Count.ToString());
            request.AddQueryParameter("offset", Offset.ToString());

            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);

            return Task.FromResult(request);
        }
        
        /// <summary>
        /// Gets or sets the identifier of the campaign you want to query.
        /// </summary>
        public int CampaignId { get; set; }
        
        /// <summary>
        /// Gets or sets the number of items to return in the list. There is a hard cap of 1000 items.
        /// </summary>
        [Required]
        public int Count { get; set; }
        
        /// <summary>
        /// Gets or sets the offset from 0, based on the count, to start listing from.
        /// </summary>
        [Required]
        public int Offset { get; set; }
        
        /// <summary>
        /// Gets or sets the start time of the window in which to search for completed calls.
        /// </summary>
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        [JsonPropertyName("windowStart")]
        [Required]
        public DateTimeOffset WindowStart { get; set; }
        
        /// <summary>
        /// Gets or sets the end time of the window in which to search for completed calls.
        /// </summary>
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        [JsonPropertyName("windowEnd")]
        [Required]
        public DateTimeOffset WindowEnd { get; set; }
    }
}
