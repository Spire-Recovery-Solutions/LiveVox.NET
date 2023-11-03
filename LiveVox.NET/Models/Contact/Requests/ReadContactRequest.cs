using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests
{
    public class ReadContactRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "contact";
        public string? Resource { get; set; } = "contacts";
        public Method RequestType { get; set; } = Method.Get;
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("acct", Account);
            return Task.FromResult(request);
        }

        public ReadContactRequest(string account)
        {
            Account = account;
        }

        /// <summary>
        /// The Account of the contact to read.
        /// </summary>
        public string Account { get; set; }
    }
}
