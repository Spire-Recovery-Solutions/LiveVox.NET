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
    public class SecureField
    {
        /// <summary>
        /// Gets or sets the secure field name where the data will be stored.
        /// </summary>
        [JsonPropertyName("field")]
        [Required]
        public SecureFieldName Field { get; set; }

        /// <summary>
        /// Gets or sets the value to place into the secure field.
        /// </summary>
        [JsonPropertyName("value")]
        [Required]
        [MaxLength(255)]
        public string Value { get; set; }
    }
}
