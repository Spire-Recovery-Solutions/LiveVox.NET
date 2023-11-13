using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Call.Requests.Supervisor.Monitor
{
    public class StartMonitorCallRequest: ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "supervisor/monitor/start";

        [JsonIgnore] public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("numberToDial", NumberToDial);
            request.AddQueryParameter("extension", Extension);
            return Task.FromResult(request);
        }
        public StartMonitorCallRequest(string numberToDial, string extension)
        {
            NumberToDial = numberToDial;
            Extension = extension;
        }

        /// <summary>
        /// Supervisor's Phone Number
        /// </summary>
        public string NumberToDial { get; set; }

        /// <summary>
        /// Extension of the Supervisor
        /// </summary>
        public string Extension { get; set; }


    }
}
