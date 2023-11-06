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
using RestSharp;

namespace LiveVox.NET.Models.Campaign.Requests
{
    public class ReadCampaignRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "campaign";
        [JsonIgnore]
        public string? Resource { get; set; } = "campaigns/{id}";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Get;

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

        /// <summary>
        /// Gets or sets the ID of the campaign to append records to.
        /// </summary>
        public int CampaignId { get; set; }

    }
}
