using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Account.Responses;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Account.Responses
{
    public class ListAccountResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the URI for the next page of entries. If not present or blank, there are no more pages.
        /// </summary>
        [JsonPropertyName("next")]
        public Uri NextPageUri { get; set; }

        /// <summary>
        /// Gets or sets the list of accounts.
        /// </summary>
        [JsonPropertyName("listAccounts")]
        public ICollection<Common.Account> Accounts { get; set; }
    }
}
