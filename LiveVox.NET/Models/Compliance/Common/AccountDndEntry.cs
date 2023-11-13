using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Compliance.Enumerations;

namespace LiveVox.NET.Models.Compliance.Common
{
    public class AccountDndEntry
    {
        /// <summary>
        /// Gets or sets the account to create/update.
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the type of blocking to apply to the account.
        /// Valid values are PERMANENT, DAILY, or NONE.
        /// </summary>
        [JsonPropertyName("block")]
        public DncEntryType Block { get; set; }
    }
}
