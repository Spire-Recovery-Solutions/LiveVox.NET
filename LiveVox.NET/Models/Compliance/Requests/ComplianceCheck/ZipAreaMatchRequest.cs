using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Compliance.Enumerations;
using RestSharp;

namespace LiveVox.NET.Models.Compliance.Requests.ComplianceCheck
{
    public class ZipAreaMatchRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "complianceCheck/zipAreaMatch";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Post;
        
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        /// <summary>
        /// Gets or sets the area code to be compared.
        /// </summary>
        [JsonPropertyName("areaCode")]
        public string AreaCode { get; set; }

        /// <summary>
        /// Gets or sets the type that determines what is classified as a "match."
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ZipAreaMatchType MatchType { get; set; }

        /// <summary>
        /// Gets or sets the zip code to be compared.
        /// </summary>
        [JsonPropertyName("zipCode")]
        public string ZipCode { get; set; }
    }
}
