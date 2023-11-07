using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;

namespace LiveVox.NET.Models.Contact.Common.ContactGroups
{
    public class ContactGroup
    {
        /// <summary>
        /// ID of the contact group.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name of the contact group.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// User who created the contact group.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// User who last modified the contact group.
        /// </summary>
        [JsonPropertyName("modifiedBy")]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Date when the contact group was created.
        /// </summary>
        [JsonPropertyName("createdAt")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Date when the contact group was last modified.
        /// </summary>
        [JsonPropertyName("modifiedAt")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset ModifiedAt { get; set; }
    }
}
