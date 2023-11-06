using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Contact.Common.ContactNotes;

namespace LiveVox.NET.Models.Contact.Responses.ContactNotes
{
    public class ListContactNotesResponse : ILiveVoxResponse
    {
        /// <summary>
        /// An array of Contact Notes for the account.
        /// </summary>
        [JsonPropertyName("listContactNotes")]
        public ICollection<ContactNote> ListContactNotes { get; set; }
    }
}
