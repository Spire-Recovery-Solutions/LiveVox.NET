using LiveVox.NET.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Common
{
    public class CallEntry
    {
        /// <summary>
        /// Gets or sets the account associated with the phone number that was dialed.
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the phone number that was dialed.
        /// </summary>
        [JsonPropertyName("phoneDialed")]
        public string PhoneDialed { get; set; }

        /// <summary>
        /// Gets or sets the time when the call was started today (Unix timestamp format).
        /// </summary>
        [JsonPropertyName("started")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset Started { get; set; }

        /// <summary>
        /// Gets or sets the time when the call was finished today (Unix timestamp format).
        /// </summary>
        [JsonPropertyName("finished")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset Finished { get; set; }

        /// <summary>
        /// Gets or sets the LiveVox result ID, which indicates the result of the call.
        /// </summary>
        [JsonPropertyName("livevoxResultId")]
        public int LiveVoxResultId { get; set; }
    }
}
