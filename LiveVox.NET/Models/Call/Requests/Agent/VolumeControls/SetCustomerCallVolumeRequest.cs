using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Enumerations.Agent;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Agent.VolumeControls
{
    public class SetCustomerCallVolumeRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/customer/call/volume";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Put;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("outGain", OutGain);
            request.AddQueryParameter("lineNumber", LineNumber);
            return Task.FromResult(request);
        }
        public SetCustomerCallVolumeRequest(int outGain, LineNumber lineNumber)
        {
            OutGain = outGain;
            LineNumber = lineNumber;
        }

        /// <summary>
        ///Value (Min = 0 and Max = 24).
        /// </summary>
        public int OutGain { get; set; }

        /// <summary>
        /// The line of the call that the Agent wants to adjust the volume for
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LineNumber LineNumber { get; set; }
    }
}
