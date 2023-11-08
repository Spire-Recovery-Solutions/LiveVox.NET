using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Contact.Responses.CustomField
{
    public class ListCustomFieldResponse : ILiveVoxResponse
    {
        /// <summary>
        /// An array of custom fields configured for the client.
        /// </summary>
        [JsonPropertyName("customFields")]
        public ICollection<Common.Contacts.CustomField> CustomFields { get; set; }
    }
}
