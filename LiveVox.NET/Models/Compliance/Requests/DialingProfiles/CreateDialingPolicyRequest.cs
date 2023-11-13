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
using LiveVox.NET.Models.Compliance.Enumerations;
using RestSharp;

namespace LiveVox.NET.Models.Compliance.Requests.DialingProfiles
{
    public class CreateDialingPolicyRequest : DialingPolicy, ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "dialingProfiles/{id}/policies";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Put;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", ProfileId, ParameterType.UrlSegment);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        public CreateDialingPolicyRequest(int profileId)
        {
            ProfileId = profileId;
        }
        
        // <summary>
        /// The ID of the Dialing Profile to be updated.
        /// </summary>
        [Required]
        public int ProfileId { get; set; }
       
    }
}
