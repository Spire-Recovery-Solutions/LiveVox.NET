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
    public class UpdateDialingProfileAddServiceRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "dialingProfiles/{id}/services/{service}";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Put;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", ProfileId, ParameterType.UrlSegment);
            request.AddParameter("service", ServiceId, ParameterType.UrlSegment);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }
        public UpdateDialingProfileAddServiceRequest(int profileId, int serviceId)
        {
            ProfileId = profileId;
            ServiceId = serviceId;
        }
        /// <summary>
        /// Gets or sets the ID of the Dialing Profile to be updated.
        /// </summary>
        [Required]
        public int ProfileId { get; set; }

        /// <summary>
        /// Gets or sets the new name of the Dialing Profile.
        /// </summary>
        [Required]
        public int ServiceId { get; set; }
    }
}
