using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Contact.Responses.Contacts
{
    public class ListAccountsResponse : ILiveVoxResponse
    {
        /// <summary>
        /// A uniform resource identifier ( URI) for the next page of entries. If next is not present, or blank, then there are no pages after this one.
        /// </summary>
        [JsonPropertyName("next")]
        public Uri NextPageUri { get; set; }

        /// <summary>
        /// A list of accounts. (The list is sorted by "name".)
        /// </summary>
        [JsonPropertyName("listAccounts")]
        public ICollection<Account.Common.Account> ListAccounts { get; set; }
    }
}
