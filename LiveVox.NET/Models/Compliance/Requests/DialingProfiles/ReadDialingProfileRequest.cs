using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Compliance.Requests.DialingProfiles
{
    public class ReadDialingProfileRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "dialingProfiles/{id}";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", ProfileId, ParameterType.UrlSegment);
            
            return Task.FromResult(request);
        }

        public ReadDialingProfileRequest(int profileId)
        {
            ProfileId = profileId;
        }
        /// <summary>
        /// Gets or sets the ID of the Dialing Profile resource to read.
        /// </summary>
        [Required]
        public int ProfileId { get; set; }
    }
}
