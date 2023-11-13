using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Campaign.Common;
using LiveVox.NET.Models.Compliance.Common;
using LiveVox.NET.Models.Compliance.Enumerations;
using RestSharp;

namespace LiveVox.NET.Models.Compliance.Requests.DncListManagement
{
    public class MultiplePhoneDncRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "dnc/multiplePhoneDnc";
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

        public MultiplePhoneDncRequest(int clientId)
        {
            ClientId = clientId;
        }
        /// <summary>
        /// Gets or sets the client ID to create the phone DNC entries for.
        /// </summary>
        public int? ClientId { get; set; }

        /// <summary>
        /// Gets or sets the type of blocking to apply to the phone(s).
        /// Valid values are PERMANENT or DAILY.
        /// </summary>
        [JsonPropertyName("block")]
        [Required]
        public DncEntryType Block { get; set; }

        /// <summary>
        /// Gets or sets an array of phone DNC entries to create/update.
        /// </summary>
        [JsonPropertyName("phoneDncEntry")]
        public ICollection<PhoneDncEntry> PhoneDncEntries { get; set; }
    }
}
