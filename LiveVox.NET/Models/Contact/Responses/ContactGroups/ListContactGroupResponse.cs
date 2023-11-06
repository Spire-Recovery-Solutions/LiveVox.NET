using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Contact.Common.ContactGroups;

namespace LiveVox.NET.Models.Contact.Responses.Contact_Groups
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
