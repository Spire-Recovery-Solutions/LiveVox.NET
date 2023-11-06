using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests.ContactNotes
{
    public class ListContactNotesRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "contact";
        public string? Resource { get; set; } = "contacts/{account}/notes";
        public Method RequestType { get; set; } = Method.Get;
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("account", Account);
            return Task.FromResult(request);
        }

        public ListContactNotesRequest(string account)
        {
            Account = account;
        }

        /// <summary>
        /// The account to list the Contact Notes for.
        /// </summary>
        public string Account { get; set; }
    }
}
