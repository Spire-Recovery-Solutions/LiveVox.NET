using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Account.Common
{
    public class FailedAccountData
    {
        /// <summary>
        /// The username who created the account.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The client ID.
        /// </summary>
        [JsonPropertyName("clientId")]
        public int ClientId { get; set; }

        /// <summary>
        /// Name of an account.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the account.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Unique account number assigned to the account within a client.
        /// </summary>
        [JsonPropertyName("accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Unique account number assigned to the account from originating source, like Salesforce.
        /// </summary>
        [JsonPropertyName("originalAccountNumber")]
        public string OriginalAccountNumber { get; set; }
    }
}
