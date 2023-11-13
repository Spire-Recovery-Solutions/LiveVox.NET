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
    public class DeleteAccountRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "account";
        [JsonIgnore]
        public string? Resource { get; set; } = "accounts/{id}";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Delete;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", AccountId, ParameterType.UrlSegment);

            return Task.FromResult(request);
        }

        public DeleteAccountRequest(int accountId)
        {
            AccountId = accountId;
        }
        /// <summary>
        /// Gets or sets the Account ID to be deleted.
        /// </summary>
        public int AccountId { get; set; }
    }
}
