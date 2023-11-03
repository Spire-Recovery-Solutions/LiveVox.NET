using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Contact.Enumerations
{
    /// <summary>
    /// Enum representing different phone block options for the LiveVox system.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PhoneBlock
    {
        /// <summary>
        /// Sets Daily Do Not Dial (DND).
        /// </summary>
        [JsonPropertyName("DAILY")]
        Daily,

        /// <summary>
        /// Sets Permanent DND.
        /// </summary>
        [JsonPropertyName("PERMANENT")]
        Permanent,

        /// <summary>
        /// Turns off both DNDs.
        /// </summary>
        [JsonPropertyName("NONE")]
        None,

        /// <summary>
        /// Sets both DNDs.
        /// </summary>
        [JsonPropertyName("BOTH")]
        Both,

        /// <summary>
        /// Turns off Daily DND.
        /// </summary>
        [JsonPropertyName("DAILY_OFF")]
        DailyOff,

        /// <summary>
        /// Turns off Permanent DND.
        /// </summary>
        [JsonPropertyName("PERMANENT_OFF")]
        PermanentOff
    }

}
