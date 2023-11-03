using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Campaign.Common;
using LiveVox.NET.Models.Campaign.Enumerations;
using RestSharp;

namespace LiveVox.NET.Models.Campaign.Requests
{
    public class SearchCampaignRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "campaign";
        public string? Resource { get; set; } = "campaigns/search";
        public Method RequestType { get; set; }

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);

            // Use AddQueryParameter to add query parameters
            request.AddQueryParameter("client", ClientId.ToString());
            request.AddQueryParameter("count", Count.ToString());
            request.AddQueryParameter("offset", Offset.ToString());

            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);

            return Task.FromResult(request);
        }
        
        /// <summary>
        /// Gets or sets the client ID for which you want to retrieve the list of Campaigns.
        /// </summary>
        public int ClientId { get; set; }

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
        /// Gets or sets an array of possible campaign statuses you want to query for.
        /// Valid values include: LOADING, SCHEDULED_UNBUILT, READY_UNBUILT, SCHEDULED, READY, REPORTED, DONE, PLAYING, PAUSED.
        /// There is an additional campaign status, BROKEN, or DEACTIVATED, but that cannot be used in the state.
        /// </summary>
        [JsonPropertyName("state")]
        public List<string> State { get; set; }

        /// <summary>
        /// Gets or sets the date/time range for which to search for matching Campaigns.
        /// </summary>
        [Required]
        [JsonPropertyName("dateRange")]
        public DateRange DateRange { get; set; }

        /// <summary>
        /// Gets or sets an array of Service IDs to include in the query.
        /// </summary>
        [JsonPropertyName("service")]
        public List<int> Service { get; set; }

        /// <summary>
        /// Gets or sets an array of Campaign Type IDs to include in the query.
        /// </summary>
        [JsonPropertyName("type")]
        public List<CampaignType> Type { get; set; }
    }
}