using LiveVox.NET.Converter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Compliance.Common
{
    public class DialtimeDncEntry
    {
        /// <summary>
        /// Gets or sets the ID for the entry.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the phone number to create the Dialtime DNC entry for.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the contact group to be assigned to the DNC entry.
        /// </summary>
        [JsonPropertyName("contactGroupId")]
        public int? ContactGroupId { get; set; }

        /// <summary>
        /// Gets or sets the expiration date of the Dialtime DNC entry.
        /// </summary>
        [JsonPropertyName("expirationDate")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset ExpirationDate { get; set; }
    }
}
