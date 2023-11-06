using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Contact.Common;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests.ContactGroups
{
    public class UpdateContactGroupRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "contact";
        public string? Resource { get; set; } = "contactGroups";
        public Method RequestType { get; set; } = Method.Put;
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("id", Id);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        public UpdateContactGroupRequest(long id)
        {
            Id = id;
        }

        /// <summary>
        /// The ID of the contact group to be updated.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// The new name of the contact group.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
