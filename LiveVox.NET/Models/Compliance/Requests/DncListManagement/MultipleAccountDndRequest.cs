using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Compliance.Common;
using RestSharp;

namespace LiveVox.NET.Models.Compliance.Requests.DncListManagement
{
    public class MultipleAccountDndRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "dnc/multipleAccountDnd";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            
            request.AddQueryParameter("client", ClientId.ToString());
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }
        public MultipleAccountDndRequest(int clientId)
        {
            ClientId = clientId;
        }
        /// <summary>
        /// Gets or sets the client ID to create/update the account DND entries for.
        /// </summary>
        public int? ClientId { get; set; }

        /// <summary>
        /// Gets or sets an array of account DND entries to create/update.
        /// </summary>
        [JsonPropertyName("accountDndEntry")]
        public ICollection<AccountDndEntry> AccountDndEntries { get; set; }
    }
}
