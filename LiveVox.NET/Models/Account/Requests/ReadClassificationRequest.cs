using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Account.Common;

namespace LiveVox.NET.Models.Account.Requests
{
    public class ReadClassificationRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "account";
        [JsonIgnore]
        public string? Resource { get; set; } = "classifications/{id}";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", ClassificationId, ParameterType.UrlSegment);

            return Task.FromResult(request);
        }

        public ReadClassificationRequest(int classificationId)
        {
            ClassificationId = classificationId;
        }
        /// <summary>
        /// Gets or sets the Classification ID to be read.
        /// </summary>
        [JsonPropertyName("id")]
        public int ClassificationId { get; set; }
    }
}
