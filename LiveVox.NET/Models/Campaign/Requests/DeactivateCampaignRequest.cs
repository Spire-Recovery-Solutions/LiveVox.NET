using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using System.Text.Json.Serialization;

namespace LiveVox.NET.Models.Campaign.Requests
{
    public class DeactivateCampaignRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "campaign";
        public string? Resource { get; set; } = "campaigns";
        public string? Deactivate { get; set; } = "deactivate";

        public Method RequestType { get; set; }
        
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest($"{Category}/{Resource}/{CampaignId}/{Deactivate}", RequestType);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }
        // <summary>
        /// Campaign to be deactivated
        /// </summary>
        [JsonPropertyName("id")]
        [Required]
        public int CampaignId { get; set; }
    }
}