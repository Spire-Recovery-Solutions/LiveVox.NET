using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Account.Common
{
    public class FailedAccount
    {
        /// <summary>
        /// Error status.
        /// </summary>
        [JsonPropertyName("status")]
        [Required]
        public string Status { get; set; }

        /// <summary>
        /// Failed account data.
        /// </summary>
        [JsonPropertyName("data")]
        public ICollection<FailedAccountData> Data { get; set; }

        /// <summary>
        /// Indicates the position of the account.
        /// </summary>
        [JsonPropertyName("ordinal")]
        [Required]
        public int? Ordinal { get; set; }
    }
}
