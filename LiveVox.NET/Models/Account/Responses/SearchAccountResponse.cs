using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Account.Common;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Account.Responses
{
    public class SearchAccountResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the URI for the next page of entries. If next is not present or blank, there are no more pages.
        /// </summary>
        [JsonPropertyName("next")]
        public Uri NextPageUri { get; set; }

        /// <summary>
        /// Gets or sets a list of matching accounts.
        /// </summary>
        [JsonPropertyName("findMatchingAccounts")]
        public List<SearchCriteria> MatchingAccounts { get; set; }
    }
}
