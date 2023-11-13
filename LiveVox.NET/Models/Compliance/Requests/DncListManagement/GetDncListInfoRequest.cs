using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public class GetDncListInfoRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "dnc/info";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            
            request.AddQueryParameter("client", ClientId.ToString());
            request.AddQueryParameter("dncType", DncType.ToString());
            request.AddQueryParameter("service", ServiceId.ToString());
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        public GetDncListInfoRequest(int client, DncEntryType dncType, int serviceId)
        {
            ClientId = client;
            DncType = dncType;
            ServiceId = serviceId;
        }
        /// <summary>
        /// Gets or sets the Client ID that the list pertains to.
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Gets or sets the type of the DNC list (DAILY or PERMANENT).
        /// </summary>
        [Required]
        public DncEntryType DncType { get; set; }

        /// <summary>
        /// Gets or sets the Service ID that restricts the list to entries specifically associated with this particular Service.
        /// </summary>
        public int ServiceId { get; set; }
    }
}
