using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Contact.Common;
using LiveVox.NET.Models.Contact.Common.Contacts;

namespace LiveVox.NET.Models.Contact.Responses.Contacts
{
    public class ListContactsResponse : ILiveVoxResponse
    {
        /// <summary>
        /// A URI for the next page of entries. If next is not present, or blank, then there are no pages after this one.
        /// </summary>
        [JsonPropertyName("next")]
        public Uri NextPageUri { get; set; }

        /// <summary>
        /// An array of contacts
        /// </summary>
        [JsonPropertyName("listContactDetails")]
        public ICollection<ContactDetailEntry> ContactDetailsList { get; set; }
    }
}
