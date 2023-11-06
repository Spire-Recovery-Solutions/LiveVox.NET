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
        public string? Resource { get; set; } = "campaigns/{id}/deactivate";
        public Method RequestType { get; set; } = Method.Post;
        
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", CampaignId, ParameterType.UrlSegment);

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