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
using RestSharp;

namespace LiveVox.NET.Models.Compliance.Requests.DialingProfiles
{
    public class UpdateDialingPolicyRequest : DialingPolicy, ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "dialingProfiles/{id}/policies/{policy}";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Put;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", ProfileId, ParameterType.UrlSegment);
            request.AddParameter("policy", ProfileId, ParameterType.UrlSegment);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }
   
    /// <summary>
    /// Gets or sets the ID of the Dialing Profile to be updated.
    /// </summary>
    [Required]
    public int ProfileId { get; set; }

    /// <summary>
    /// Gets or sets the ID of the policy to be updated.
    /// </summary>
    [Required]
    public int PolicyId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to remove any defined areaCode so the policy applies to the entire state.
    /// </summary>
    [JsonPropertyName("clearAreaCode")]
    public bool ClearAreaCode { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to remove any defined startTime and endTime so the policy applies to the entire day.
    /// </summary>
    [JsonPropertyName("clearTimeRange")]
    public bool ClearTimeRange { get; set; }
    }
}
