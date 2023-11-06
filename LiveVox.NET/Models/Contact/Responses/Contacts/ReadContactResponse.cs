using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Contact.Common;
using LiveVox.NET.Models.Contact.Common.Contacts;

namespace LiveVox.NET.Models.Contact.Responses.Contacts
{
    public class ReadContactResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Details of the contact
        /// </summary>
        [JsonPropertyName("readContactDetails")]
        public ContactDetailEntry ContactDetails { get; set; }
    }
}
