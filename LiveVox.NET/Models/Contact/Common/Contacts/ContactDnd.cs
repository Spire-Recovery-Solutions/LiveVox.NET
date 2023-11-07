using LiveVox.NET.Models.Contact.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Contact.Common.Contacts
{
    public class ContactDnd
    {
        /// <summary>
        /// Identifies the account, normally coming from a client's system of record.
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// An array of phone numbers associated with the contact. This key also indicates how the DND settings are updated.
        /// </summary>
        [JsonPropertyName("updateContactDND")]
        public ICollection<Phone> UpdateContactDND { get; set; }

        /// <summary>
        /// Blocks any dialing to this account for the entire day or permanently
        /// </summary>
        [JsonPropertyName("accountBlock")]
        public DialBlockOption AccountBlock { get; set; }
    }
}
