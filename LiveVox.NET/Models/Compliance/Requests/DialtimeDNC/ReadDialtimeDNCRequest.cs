using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Requests.DialtimeDnc
{
    public class ReadDialtimeDncRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "dialtime/dnc/{dncId}";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("dncId", DncId, ParameterType.UrlSegment);

            return Task.FromResult(request);
        }

        public ReadDialtimeDncRequest(int dncId)
        {
            DncId = dncId; 
        }
        /// <summary>
        /// Gets or sets the Dnc entry ID to be read.
        /// </summary>
        [JsonPropertyName("dncId")]
        public int DncId { get; set; }
    }
}
