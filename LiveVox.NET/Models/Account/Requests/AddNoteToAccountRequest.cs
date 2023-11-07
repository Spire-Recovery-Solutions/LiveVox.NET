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
    public class AddNoteToAccountRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "account";
        public string? Resource { get; set; } = "accounts/{id}/notes";
        public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", AccountId, ParameterType.UrlSegment);

            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }
        
        /// <summary>
        /// Account ID to be read.
        /// </summary>
        [JsonPropertyName("id")]
        public int AccountId { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the note.
        /// </summary>
        [JsonPropertyName("name")]
        [Required]
        public string NoteName { get; set; }

        /// <summary>
        /// Gets or sets the description of the note.
        /// </summary>
        [JsonPropertyName("description")]
        public string NoteDescription { get; set; }
    }
}
