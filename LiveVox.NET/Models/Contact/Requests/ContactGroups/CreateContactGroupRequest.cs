using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Contact.Common;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests.Contact_Groups
{
    public class CreateContactGroupRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "contact";
        public string? Resource { get; set; } = "contactGroups";
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

        // Properties to hold the request data
        /// <summary>
        /// The name of the contact group.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
