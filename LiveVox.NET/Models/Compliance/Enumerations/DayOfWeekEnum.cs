using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Compliance.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DayOfWeekEnum
    {
        /// <summary>
        /// Monday.
        /// </summary>
        [JsonPropertyName("MONDAY")]
        MONDAY,

        /// <summary>
        /// Tuesday.
        /// </summary>
        [JsonPropertyName("TUESDAY")]
        TUESDAY,

        /// <summary>
        /// Wednesday.
        /// </summary>
        [JsonPropertyName("WEDNESDAY")]
        WEDNESDAY,

        /// <summary>
        /// Thursday.
        /// </summary>
        [JsonPropertyName("THURSDAY")]
        THURSDAY,

        /// <summary>
        /// Friday.
        /// </summary>
        [JsonPropertyName("FRIDAY")]
        FRIDAY,

        /// <summary>
        /// Saturday.
        /// </summary>
        [JsonPropertyName("SATURDAY")]
        SATURDAY,

        /// <summary>
        /// Sunday.
        /// </summary>
        [JsonPropertyName("SUNDAY")]
        SUNDAY,

        /// <summary>
        /// Weekdays (Monday to Friday).
        /// </summary>
        [JsonPropertyName("WEEKDAY")]
        WEEKDAY,

        /// <summary>
        /// Weekends (Saturday and Sunday).
        /// </summary>
        [JsonPropertyName("WEEKEND")]
        WEEKEND,

        /// <summary>
        /// All days.
        /// </summary>
        [JsonPropertyName("ALL")]
        ALL
    }
}