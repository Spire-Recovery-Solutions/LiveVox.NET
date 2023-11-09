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
    public class DeleteDialingPolicyRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "dialingProfiles/{id}/policies/{policy}";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Delete;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", ProfileId, ParameterType.UrlSegment);
            request.AddParameter("policy", PolicyId, ParameterType.UrlSegment);
            
            return Task.FromResult(request);
        }
        /// <summary>
        /// Gets or sets the ID of the Dialing Profile to be updated.
        /// </summary>
        [Required]
        public int ProfileId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the policy to be removed.
        /// </summary>
        [Required]
        public int PolicyId { get; set; }
    }
}
