using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Contact.Common.Contacts;

namespace LiveVox.NET.Models.Contact.Responses.Contacts
{
    public class SearchContactsResponse : ILiveVoxResponse
    {
        /// <summary>
        /// A URI for the next page of entries. If next is not present, or blank, then there are no pages after this one.
        /// </summary>
        [JsonPropertyName("next")]
        public Uri NextPageUri { get; set; }

        /// <summary>
        /// An array of contacts that match the specified filter criteria in the request.
        /// </summary>
        [JsonPropertyName("findMatchingContactsDetails")]
        public ICollection<ContactDetails> FindMatchingContactsDetails { get; set; }
    }
}
