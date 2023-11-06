using System.ComponentModel.DataAnnotations;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests.Contacts
{
    public class ListContactsRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "contact";
        public string? Resource { get; set; } = "contacts";
        public Method RequestType { get; set; } = Method.Get;
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("count", Count);
            request.AddQueryParameter("offset", Offset);

            return Task.FromResult(request);
        }
        public ListContactsRequest(int count, int offset)
        {
            Count = count;
            Offset = offset;
        }

        /// <summary>
        /// Specifies the number of items to return in the list. There is a hard cap of 1000 items.
        /// </summary>
        [Required]
        public int Count { get; set; }

        /// <summary>
        /// Required for pagination. Specifies the offset from 0, based on the count, to start listing from.
        /// </summary>
        [Required]
        public int Offset { get; set; }
    }
}
