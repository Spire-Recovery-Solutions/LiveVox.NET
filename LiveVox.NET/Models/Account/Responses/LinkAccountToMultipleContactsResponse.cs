using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Account.Common;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Account.Responses
{
    public class LinkAccountToMultipleContactsResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the number of contacts successfully linked to the account.
        /// </summary>
        [JsonPropertyName("successCount")]
        [Required]
        public int SuccessCount { get; set; }

        /// <summary>
        /// Gets or sets the number of contacts failed to be linked to the account.
        /// </summary>
        [JsonPropertyName("failCount")]
        [Required]
        public int FailCount { get; set; }

        /// <summary>
        /// Gets or sets a list of hints to failed data.
        /// </summary>
        [JsonPropertyName("failedData")]
        public ICollection<FailedDataItem> FailedData { get; set; }
    }
}
