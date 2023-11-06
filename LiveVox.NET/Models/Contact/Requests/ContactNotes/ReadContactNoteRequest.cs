using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests.ContactNotes
{
    public class ReadContactNoteRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "contact";
        public string? Resource { get; set; } = "contacts/{account}/notes";
        public Method RequestType { get; set; } = Method.Get;
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("account", Account);
            request.AddQueryParameter("id", Id);
            return Task.FromResult(request);
        }

        public ReadContactNoteRequest(string account, long id)
        {
            Account = account;
            Id = id;
        }

        /// <summary>
        /// Specifies the account that the note is assigned to.
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// The ID of the Contact Note to be read.
        /// </summary>
        public long Id { get; set; }
    }
}
