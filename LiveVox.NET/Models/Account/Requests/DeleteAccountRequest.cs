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
        public string? Category { get; set; } = "account";
        public string? Resource { get; set; } = "accounts/{id}";
        public Method RequestType { get; set; } = Method.Delete;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", AccountId, ParameterType.UrlSegment);

            return Task.FromResult(request);
        }
        /// <summary>
        /// Gets or sets the Account ID to be deleted.
        /// </summary>
        public int AccountId { get; set; }
    }
}
