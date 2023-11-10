using LiveVox.NET.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Compliance.Common
{
    public class SmsDncEntry
    {
        /// <summary>
        /// Gets or sets the phone number for which you are creating the SMS DNC entry. The format is a 10-digit string.
        /// </summary>
        [JsonPropertyName("sms")]
        public string Sms { get; set; }

        /// <summary>
        /// Gets or sets the contact group assigned to the DNC entry. (Optional)
        /// </summary>
        [JsonPropertyName("contactGroupId")]
        public int? ContactGroupId { get; set; }

        /// <summary>
        /// Gets or sets the expiration date of the SMS DNC entry. (Optional)
        /// </summary>
        [JsonPropertyName("expirationDate")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset ExpirationDate { get; set; }
    }
}
