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

namespace LiveVox.NET.Models.Compliance.Requests.EmailDnc
{
    public class ListEmailDncRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "email/dnc";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);

            request.AddQueryParameter("count", Count.ToString());
            request.AddQueryParameter("Offset", Offset.ToString());
            
            return Task.FromResult(request);
        }

        public ListEmailDncRequest(int count, int offset)
        {
            Count = count;
            Offset = offset;
        }
        
        /// <summary>
        /// Gets or sets the starting point from which to list items.
        /// </summary>
        [Required]
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets the number of items to return in the list (up to 1000).
        /// </summary>
        [Required]
        public int Count { get; set; }
    }
}
