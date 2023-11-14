using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.CallControl
{
    public class GetTermCodeRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/termCode";

        [JsonIgnore] 
        public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("serviceId", ServiceId);
            return Task.FromResult(request);
        }
        public GetTermCodeRequest(int serviceId)
        {
            ServiceId = serviceId;
        }

        /// <summary>
        /// ID of a Service on which agent wants to get the term code.
        /// </summary>
        public int ServiceId { get; set; }
    }
}
