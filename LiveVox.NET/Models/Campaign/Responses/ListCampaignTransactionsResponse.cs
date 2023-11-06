using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Campaign.Common;

namespace LiveVox.NET.Models.Campaign.Responses
{
    public class ListCampaignTransactionsResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets a URI for the next page of entries. If not present or blank, there are no more pages.
        /// </summary>
        [JsonPropertyName("next")]
        public Uri Next { get; set; }

        /// <summary>
        /// Gets or sets a container for a page of account transaction entries.
        /// </summary>
        [JsonPropertyName("transaction")]
        public List<AccountTransactionEntry> Transaction { get; set; }
    }
}