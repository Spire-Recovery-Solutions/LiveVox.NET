using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Serialization;
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
    public class CreateCampaignRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "campaign";
        public string? Resource { get; set; } = "campaigns";
        public Method RequestType { get; set; }

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        // <summary>
        /// Gets or sets the campaign file containing the records to be uploaded to the platform.
        /// </summary>
        [JsonPropertyName("campaignFile")]
        [Required]
        public CampaignFile CampaignFile { get; set; }

        /// <summary>
        /// Gets or sets the configuration properties for the campaign.
        /// </summary>
        [JsonPropertyName("campaignConfiguration")]
        [Required]
        public CampaignConfiguration CampaignConfiguration { get; set; }
    }
}
