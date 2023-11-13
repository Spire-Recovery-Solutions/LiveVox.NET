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

namespace LiveVox.NET.Models.Account.Requests
{
    public class CreateClassificationRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "account";
        [JsonIgnore]
        public string? Resource { get; set; } = "classifications";
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
        /// Gets or sets the name of the classification.
        /// </summary>
        [JsonPropertyName("name")]
        [Required]
        public string ClassificationName { get; set; }
    }
}
