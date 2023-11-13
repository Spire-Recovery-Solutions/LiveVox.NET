using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Account.Enumerations;

namespace LiveVox.NET.Models.Account.Common
{
    /// <summary>
    /// Represents the history of an account.
    /// </summary>
    public class AccountHistory
    {
        /// <summary>
        /// Gets or sets the client ID of the history record.
        /// </summary>
        [JsonPropertyName("clientId")]
        public int ClientId { get; set; }

        /// <summary>
        /// Gets or sets the creation date of the history record.
        /// </summary>
        [JsonPropertyName("createdDate")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the description of the changes.
        /// </summary>
        [JsonPropertyName("descriptions")]
        public string HistoryDescription { get; set; }

        /// <summary>
        /// Gets or sets the primary key for the history record.
        /// </summary>
        [JsonPropertyName("id")]
        public int HistoryId { get; set; }

        /// <summary>
        /// Gets or sets the name of the history record.
        /// </summary>
        [JsonPropertyName("name")]
        public string HistoryName { get; set; }

        /// <summary>
        /// Gets or sets the type of record being updated.
        /// </summary>
        [JsonPropertyName("parentType")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ParentType ParentType { get; set; }

        /// <summary>
        /// Gets or sets the ID associated with the parentType record.
        /// </summary>
        [JsonPropertyName("parentId")]
        public int ParentId { get; set; }
    }
}
