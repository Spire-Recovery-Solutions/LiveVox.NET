using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace LiveVox.NET.Models.Call.Requests.Agent.CallControl
{
    public class GetAreaCodeRequest: ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/areaCode";

        [JsonIgnore] 
        public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("serviceId", ServiceId);
            request.AddQueryParameter("phoneNumber", PhoneNumber);
            return Task.FromResult(request);
        }
        public GetAreaCodeRequest(int serviceId, string phoneNumber)
        {
            ServiceId = serviceId;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// ID of a Service on which agent wants to get the area code.
        /// </summary>
        public int ServiceId { get; set; }

        /// <summary>
        /// Phone number for which the agent wants to get the area code.
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
