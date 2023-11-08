using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Campaign.Requests
{
    public class GetCampaignListInfoRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "campaign";
        [JsonIgnore]
        public string? Resource { get; set; } = "campaigns/info";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Get;
        
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }
    }
}
