using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Account.Requests
{
    public class UpdateAccountRequest : Common.Account , ILiveVoxRequest
    {
         
        [JsonIgnore]
        public string? Category { get; set; } = "account";
        [JsonIgnore]
        public string? Resource { get; set; } = "accounts/{id}";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Put;
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", AccountId, ParameterType.UrlSegment);

            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        public UpdateAccountRequest(int accountId)
        {
            AccountId = accountId;
        }
        
        /// <summary>
        /// Account ID  to be updated.
        /// </summary>
        public int AccountId { get; set; }
    }
}
