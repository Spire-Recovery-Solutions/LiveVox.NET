using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Requests.DialingProfiles
{
    public class ListDialingProfileRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "dialingProfiles";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Delete;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("client", ClientId.ToString());
            request.AddQueryParameter("count", Count.ToString());
            request.AddQueryParameter("offset", Offset.ToString());

            
            return Task.FromResult(request);
        }

        public ListDialingProfileRequest(int clientId, int count, int offset)
        {
            ClientId = clientId;
            Count = count;
            Offset = offset;
        }

        /// <summary>
        /// Gets or sets the ID of the client. Identifies which Client the list pertains to.
        /// </summary>
        public int? ClientId { get; set; }

        /// <summary>
        /// Gets or sets the number of items to return in the list. There is a hard cap of 1000 items.
        /// </summary>
        [Required]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the offset from 0, based on the count, to start listing from. Required for pagination.
        /// </summary>
        [Required]
        public int Offset { get; set; }
    }
}
