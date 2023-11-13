using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Account.Requests
{
    public class ListAllAccountTypeRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "account";
        [JsonIgnore]
        public string? Resource { get; set; } = "types";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);

            return Task.FromResult(request);
        }
    }
}
