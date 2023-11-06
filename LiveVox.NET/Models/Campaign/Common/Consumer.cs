using LiveVox.NET.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Common
{
    public class Consumer
    {
        /// <summary>
        /// Gets or sets the first name of the consumer.
        /// </summary>
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the consumer.
        /// </summary>
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the date of birth of the consumer.
        /// </summary>
        [JsonPropertyName("dateOfBirth")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the email address of the consumer.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the Social Security number of the consumer.
        /// </summary>
        [JsonPropertyName("ssn")]
        public string Ssn { get; set; }

        /// <summary>
        /// Gets or sets the zip code of the consumer.
        /// </summary>
        [JsonPropertyName("zipCode")]
        public string ZipCode { get; set; }
    }
}