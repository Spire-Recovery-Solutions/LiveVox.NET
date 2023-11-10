using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Compliance.Requests.SmsDnc
{
    public class DeleteSmsDncRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "sms/dnc/{dncId}";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Delete;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("dncId", DncId, ParameterType.UrlSegment);

            return Task.FromResult(request);
        }
        /// <summary>
        /// Gets or sets the SMS DNC entry ID to be deleted.
        /// </summary>
        [JsonPropertyName("dncId")]
        public int DncId { get; set; }
    }
}
