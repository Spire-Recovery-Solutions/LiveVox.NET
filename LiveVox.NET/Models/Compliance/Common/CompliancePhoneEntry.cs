using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Compliance.Enumerations;

namespace LiveVox.NET.Models.Compliance.Common
{
    public class CompliancePhoneEntry
    {
        /// <summary>
        /// Gets or sets one of the phone numbers to dial associated with the account.
        /// </summary>
        [JsonPropertyName("phone")]
        [Required]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the position associated with the phone number.
        /// </summary>
        [JsonPropertyName("ordinal")]
        [Required]
        public int Ordinal { get; set; }

        /// <summary>
        /// Gets or sets the type of blocking to apply to the account phone combination.
        /// Valid values are PERMANENT, DAILY, or NONE.
        /// </summary>
        [JsonPropertyName("phoneBlock")]
        [Required]
        public DncEntryType PhoneBlock { get; set; }
    }
}
