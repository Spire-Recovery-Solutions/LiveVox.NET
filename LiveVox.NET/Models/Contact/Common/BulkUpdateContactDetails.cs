using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Contact.Common
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
