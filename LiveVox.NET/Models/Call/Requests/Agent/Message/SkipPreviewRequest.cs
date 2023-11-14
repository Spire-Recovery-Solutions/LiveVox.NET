using LiveVox.NET.Models.Base;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Requests.Agent.Message
{
    public class SkipPreviewRequest: ILiveVoxRequest
    {
        [JsonIgnore] 
        public string? Category { get; set; } = "callControl";

        [JsonIgnore] 
        public string? Resource { get; set; } = "agent/customer/call/preview/skip";

        [JsonIgnore] 
        public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);

            request.AddQueryParameter("transactionId", TransactionId);
            return Task.FromResult(request);
        }

        public SkipPreviewRequest(string transactionId)
        {
            TransactionId = transactionId;
        }

        /// <summary>
        /// Transaction ID.
        /// </summary>
        public string TransactionId { get; set; }
    }
}
