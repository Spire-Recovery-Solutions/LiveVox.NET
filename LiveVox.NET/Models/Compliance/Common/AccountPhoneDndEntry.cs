using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Compliance.Common
{
    public class AccountPhoneDndEntry
    {
        /// <summary>
        /// Gets or sets the account to create/update.
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets an array of phone numbers to block for the specified account.
        /// </summary>
        [JsonPropertyName("phones")]
        public ICollection<PhoneEntry> Phones { get; set; }

    }
}
