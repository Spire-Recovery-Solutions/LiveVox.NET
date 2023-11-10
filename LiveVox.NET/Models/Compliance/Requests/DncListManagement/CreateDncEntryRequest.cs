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

namespace LiveVox.NET.Models.Compliance.Requests.DncListManagement
{
    public class CreateDncEntryRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "dnc/";
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
        /// Gets or sets the client ID to associate the entry with.
        /// </summary>
        [JsonPropertyName("clientId")]
        public int? ClientId { get; set; }

        /// <summary>
        /// Gets or sets the type of the DNC entry (DAILY or PERMANENT).
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DncEntryType Type { get; set; }

        /// <summary>
        /// Gets or sets the service ID to associate the entry with.
        /// </summary>
        [JsonPropertyName("serviceId")]
        public int? ServiceId { get; set; }

        /// <summary>
        /// Gets or sets the phone number for the DNC entry. At least one phone, account, or zip must be present.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the account for the DNC entry.
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the zip code for the DNC entry.
        /// </summary>
        [JsonPropertyName("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Gets or sets the DNC rule for the entry.
        /// </summary>
        [JsonPropertyName("dncRule")]
        public string DncRule { get; set; }
    }
}
