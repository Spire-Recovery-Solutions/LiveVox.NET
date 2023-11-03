using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests
{
    public class ListAccountsRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "contact";
        public string? Resource { get; set; } = "contacts/{contactId}/accounts";
        public Method RequestType { get; set; } = Method.Get;
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("contactId", ContactId);
            request.AddQueryParameter("count", Count);
            request.AddQueryParameter("offset", Offset);
            
            return Task.FromResult(request);
        }
        public ListAccountsRequest(string contactId, int count, int offset)
        {
            Count = count;
            Offset = offset;
            ContactId = contactId;
        }

        /// <summary>
        /// Specifies the number of items to return in the list. There is a hard cap of 1000 items.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Required for pagination. Specifies the offset from 0, based on the count, to start listing from.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// The ID of the contact. It is a unique ID to identify a contact in Contact Manager.
        /// </summary>
        public string ContactId { get; set; }
    }
}
