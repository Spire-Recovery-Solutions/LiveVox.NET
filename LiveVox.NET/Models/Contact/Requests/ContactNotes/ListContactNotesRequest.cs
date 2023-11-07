using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests.ContactNotes
{
    public class ListContactNotesRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "contact";
        [JsonIgnore]
        public string? Resource { get; set; } = "contacts/{account}/notes";
        [JsonIgnore]
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
