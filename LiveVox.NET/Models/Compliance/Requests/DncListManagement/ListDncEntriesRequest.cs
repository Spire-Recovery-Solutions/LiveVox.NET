using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
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
    public class ListDncEntriesRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "dnc";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            
            request.AddQueryParameter("client", ClientId.ToString());
            request.AddQueryParameter("dncType", DncType.ToString());
            request.AddQueryParameter("service", ServiceId.ToString());
            request.AddQueryParameter("count", Count.ToString());
            request.AddQueryParameter("offset", Offset.ToString());

            return Task.FromResult(request);
        }

        public ListDncEntriesRequest(int clientId, DncEntryType dncType, int serviceId, int count, int offset)
        {
            ClientId = clientId;
            DncType = dncType;
            ServiceId = serviceId;
            Count = count;
            Offset = offset;
        }
        /// <summary>
        /// Gets or sets the client ID that identifies which client the list pertains to.
        /// </summary>
        public int? ClientId { get; set; }

        /// <summary>
        /// Gets or sets the DNC type (DAILY or PERMANENT).
        /// </summary>
        
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [Required]
        public DncEntryType DncType { get; set; }

        /// <summary>
        /// Gets or sets the service ID that restricts the list to entries associated with this particular Service.
        /// </summary>
        public int? ServiceId { get; set; }

        /// <summary>
        /// Gets or sets the number of items to return in the list (there is a hard cap of 1000 items).
        /// </summary>
        [Required]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the offset for pagination, specifying the offset from 0 to start listing from.
        /// </summary>
        [Required]
        public int Offset { get; set; }
    }
}
