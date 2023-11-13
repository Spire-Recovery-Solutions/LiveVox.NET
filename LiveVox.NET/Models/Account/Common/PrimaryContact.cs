using LiveVox.NET.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Account.Common
{
    public class PrimaryContact
    {
        /// <summary>
        /// Gets or sets the primary key for the contact record.
        /// </summary>
        [JsonPropertyName("id")]
        public int ContactId { get; set; }

        /// <summary>
        /// Gets or sets the creation date of the contact record.
        /// </summary>
        [JsonPropertyName("createdDate")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the name of the user who created the contact record.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the modification date of the contact record.
        /// </summary>
        [JsonPropertyName("modifiedDate")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset ModifiedDate { get ; set; }

        /// <summary>
        /// Gets or sets the name of the user who modified the contact record.
        /// </summary>
        [JsonPropertyName("modifiedBy")]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the name of the contact record.
        /// </summary>
        [JsonPropertyName("contact")]
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or sets the ID for the account record that is associated with the contact.
        /// </summary>
        [JsonPropertyName("accountId")]
        public int AccountId { get; set; }

        /// <summary>
        /// Gets or sets the unique account number assigned to the account from the originating source (e.g., Salesforce).
        /// Used to fetch the accountId only.
        /// </summary>
        [JsonPropertyName("originalAccountId")]
        public string OriginalAccountId { get; set; }
    }
}
