using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Compliance.Common;
using RestSharp;

namespace LiveVox.NET.Models.Compliance.Requests.DialingProfiles
{
    public class CreateDialingProfileRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "dialingProfiles";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", ClientId, ParameterType.UrlSegment);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }
        public CreateDialingProfileRequest(int clientId)
        {
            ClientId = clientId;
        }
        
        /// <summary>
        /// Gets or sets the ID of the Client under which the Dialing Profile will be created.
        /// </summary>
        public int ClientId { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the Dialing Profile to be created.
        /// </summary>
        [JsonPropertyName("name")]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the Dialing Profile to be created.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets an array of policies to be created under the Dialing Profile.
        /// </summary>
        [JsonPropertyName("policy")]
        public List<DialingPolicy> Policies { get; set; }

    }
}
