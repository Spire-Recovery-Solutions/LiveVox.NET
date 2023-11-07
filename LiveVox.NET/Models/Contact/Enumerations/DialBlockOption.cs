using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Contact.Enumerations
{
    /// <summary>
    /// Enum representing different account block options.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DialBlockOption
    {
        /// <summary>
        /// Sets Daily Do Not Dial (DND).
        /// </summary>
        [JsonPropertyName("DAILY")]
        Daily = 0,

        /// <summary>
        /// Sets Permanent DND.
        /// </summary>
        [JsonPropertyName("PERMANENT")]
        Permanent = 1,

        /// <summary>
        /// Turns off both DNDs.
        /// </summary>
        [JsonPropertyName("NONE")]
        None = 2,

        /// <summary>
        /// Sets both DNDs.
        /// </summary>
        [JsonPropertyName("BOTH")]
        Both = 3,

        /// <summary>
        /// Turns off Daily DND.
        /// </summary>
        [JsonPropertyName("DAILY_OFF")]
        DailyOff = 4,

        /// <summary>
        /// Turns off Permanent DND.
        /// </summary>
        [JsonPropertyName("PERMANENT_OFF")]
        PermanentOff = 5
    }
}
