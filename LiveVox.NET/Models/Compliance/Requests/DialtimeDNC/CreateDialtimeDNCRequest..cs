using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Compliance.Requests.DialtimeDNC
{
    public class CreateDialtimeDNCRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "campaign";
        [JsonIgnore]
        public string? Resource { get; set; } = "dialtime/dnc";
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
        /// Gets or sets the phone number to create the Dialtime DNC entry for.
        /// </summary>
        [JsonPropertyName("phone")]
        [Required]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the contact group to be assigned to the DNC entry.
        /// </summary>
        [JsonPropertyName("contactGroupId")]
        public int? ContactGroupId { get; set; }

        /// <summary>
        /// Gets or sets the expiration date of the Dialtime DNC entry.
        /// </summary>
        [JsonPropertyName("expirationDate")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset ExpirationDate { get; set; }

    }
}
