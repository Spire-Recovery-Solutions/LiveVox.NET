using LiveVox.NET.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Compliance.Common
{
    public class EmailDNCEntry
    {
        /// <summary>
        /// Gets or sets the ID for the entry.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the email address for which you are creating the Email DNC entry.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the contact group that is assigned to the Email DNC entry.
        /// </summary>
        [JsonPropertyName("contactGroupId")]
        public int? ContactGroupId { get; set; }

        /// <summary>
        /// Gets or sets the expiration date of the Email DNC entry.
        /// </summary>
        [JsonPropertyName("expirationDate")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset ExpirationDate { get; set; }
    }
}
