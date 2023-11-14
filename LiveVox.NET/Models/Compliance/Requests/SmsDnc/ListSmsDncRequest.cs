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

namespace LiveVox.NET.Models.Compliance.Requests.SmsDnc
{
    public class ListSmsDncRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "sms/dnc";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            
            request.AddQueryParameter("count", Count.ToString());
            request.AddQueryParameter("Offset", Offset.ToString());

            return Task.FromResult(request);
        }

        public ListSmsDncRequest(int count, int offset)
        {
            Count = count;
            Offset = offset;
        }
        /// <summary>
        /// Gets or sets the number of items to return in the list. There is a limit of 1000 items.
        /// </summary>
        [Required]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the offset from 0, based on the count parameter, from which to start listing.
        /// </summary>
        [Required]
        public int Offset { get; set; }
    }
}
