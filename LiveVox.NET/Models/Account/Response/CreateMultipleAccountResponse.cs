using LiveVox.NET.Models.Account.Common;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Account.Response
{
    public  class CreateMultipleAccountResponse : ILiveVoxResponse
    {
         /// <summary>
        /// Gets or sets the number of accounts successfully created.
        /// </summary>
        [JsonPropertyName("successCount")]
        [Required]
        public int SuccessCount { get; set; }

        /// <summary>
        /// Gets or sets the number of accounts successfully updated.
        /// </summary>
        [JsonPropertyName("updateCount")]
        [Required]
        public int UpdateCount { get; set; }

        /// <summary>
        /// Gets or sets the number of accounts that failed to be created.
        /// </summary>
        [JsonPropertyName("failCount")]
        [Required]
        public int FailCount { get; set; }

        /// <summary>
        /// Gets or sets a list of failed account data.
        /// </summary>
        [JsonPropertyName("failedData")]
        public ICollection<FailedAccount> FailedData { get; set; }
    }
}
