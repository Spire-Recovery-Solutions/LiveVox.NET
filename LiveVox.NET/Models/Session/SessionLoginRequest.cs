using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Session
{
    public class SessionLoginRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "session";
        public string? Resource { get; set; } = "login";
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
        /// Name of LiveVox Client on whose behalf the session is being created. 
        /// This is not the "Display Name" of the Client, but rather the "Client Code" 
        /// as it appears in the Client Editor screen in the LiveVox Portal GUI.
        /// </summary>
        [JsonPropertyName("clientName")]
        [Required]
        public string ClientName { get; set; }

        /// <summary>
        /// Name of LiveVox user or Agent on whose behalf the session is being created.
        /// </summary>
        [JsonPropertyName("userName")]
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// Password associated with the Username.
        /// </summary>
        [JsonPropertyName("password")]
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// If set to true the password update is for an Agent.
        /// If not included in the request it defaults to 'false' meaning that the login request is for a User.
        /// </summary>
        [JsonPropertyName("agent")]
        public bool Agent { get; set; } = false;
    }
}
