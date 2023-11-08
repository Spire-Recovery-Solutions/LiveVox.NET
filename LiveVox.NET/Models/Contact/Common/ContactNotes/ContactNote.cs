using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Contact.Common.ContactNotes
{
    public class ContactNote
    {
        /// <summary>
        /// The ID of the Contact Note.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Contents of the note.
        /// </summary>
        [Required]
        [JsonPropertyName("note")]
        public string Note { get; set; }
    }
}
