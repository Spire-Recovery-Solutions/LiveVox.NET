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
    public class GetDialingProfileListInfoRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "dialingProfiles/info";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("client", ClientId.ToString());

            
            return Task.FromResult(request);
        }
        public GetDialingProfileListInfoRequest(int clientId)
        {
            ClientId = clientId;  
        }
        /// <summary>
        /// Gets or sets the ID of the Dialing Profile to be deleted.
        /// </summary>
        [Required]
        public int ClientId { get; set; }
    }
}
