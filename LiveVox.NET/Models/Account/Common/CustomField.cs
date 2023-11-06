using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Account.Enumerations;

namespace LiveVox.NET.Models.Account.Common
{
    public class CustomField
    {
        /// <summary>
        /// Gets or sets the custom field name where the data will be stored.
        /// </summary>
        [JsonPropertyName("field")]
        [Required]
        public CustomFieldName Field { get; set; }

        /// <summary>
        /// Gets or sets the value to place into the custom field.
        /// </summary>
        [JsonPropertyName("value")]
        [Required]
        [MaxLength(255)]
        public string Value { get; set; }
    }
}
