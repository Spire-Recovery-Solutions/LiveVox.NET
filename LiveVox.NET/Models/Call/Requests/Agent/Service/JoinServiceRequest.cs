using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.Service
{
    public class JoinServiceRequest: ILiveVoxRequest
    {
        [JsonIgnore] 
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/service/join";

        [JsonIgnore] 
        public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);

            request.AddQueryParameter("serviceId", ServiceId);
            request.AddQueryParameter("phoneNumber", PhoneNumber);
            request.AddQueryParameter("sipId", SipId);
            return Task.FromResult(request);
        }

        public JoinServiceRequest(int serviceId, string phoneNumber, string sipId)
        {
            ServiceId = serviceId;
            PhoneNumber = phoneNumber;
            SipId = sipId;
        }

        /// <summary>
        /// ID of the Service which the Agent wants to join.
        /// </summary>
        public int ServiceId { get; set; }

        /// <summary>
        /// Phone number on which the Agent receives a call. If the value is not provided Agent receives call for his configured number in LVP.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// SIP ID for Agent.
        /// </summary>
        public string SipId { get; set; }
    }
}
