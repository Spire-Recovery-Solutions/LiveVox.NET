using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.TransferAndConference
{
    public class GetPhonebookDetailsExtRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/phonebook/ext";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("serviceId", ServiceId);
            return Task.FromResult(request);
        }
        public GetPhonebookDetailsExtRequest(int serviceId)
        {
            ServiceId = serviceId;
        }

        /// <summary>
        /// Limits the phonebooks to only ones available for this particular Service.
        /// </summary>
        public int ServiceId { get; set; }
    }
}
