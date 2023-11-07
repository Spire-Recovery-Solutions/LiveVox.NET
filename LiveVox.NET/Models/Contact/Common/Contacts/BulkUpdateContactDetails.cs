using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LiveVox.NET.Models.Contact.Common.Contacts
{
    public class BulkUpdateContactDetails : BulkCreateContactDetails
    {
        /// <summary>
        /// Contact ID.
        /// </summary>
        [Required]
        [JsonPropertyName("id")]
        public long Id { get; set; } 
    }
}
