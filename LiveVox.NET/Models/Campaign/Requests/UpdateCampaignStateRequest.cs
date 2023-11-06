using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Campaign.Enumerations;
using RestSharp;

namespace LiveVox.NET.Models.Campaign.Requests
{
    public class UpdateCampaignStateRequest : ILiveVoxRequest
    {

        public string Category { get; set; } = "campaign";
        public string Resource { get; set; } = "campaigns/{id}/state";
        public Method RequestType { get; set; } = Method.Put;
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
        /// ID of the campaign which will have its state updated.
        /// </summary>
        [Required]
        public int CampaignId { get; set; }

        /// <summary>
        /// Desired state of the campaign. Possible values are STOP, PLAY, PAUSE, or BUILD.
        /// </summary>
        [Required]
        public CampaignState State { get; set; }
    }
}
