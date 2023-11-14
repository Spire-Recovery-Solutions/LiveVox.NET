using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Contact.Common.ContactGroups;

namespace LiveVox.NET.Models.Contact.Responses.ContactGroups
{
    public class ListContactGroupResponse : ILiveVoxResponse
    {
        /// <summary>
        /// A URI for the next page of entries. If next is not present, or blank, then there are no pages after this one.
        /// </summary>
        [JsonPropertyName("next")]
        public string Next { get; set; }

        /// <summary>
        /// An array of contact groups configured for the client.
        /// </summary>
        [JsonPropertyName("contactGroup")]
        public ICollection<ContactGroup> ContactGroups { get; set; }
    }

}
