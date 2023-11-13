using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Compliance.Enumerations;

namespace LiveVox.NET.Models.Compliance.Common
{
    public class DialingPolicy
    {
        /// <summary>
        /// Gets or sets the day of the week the policy will restrict.
        /// Possible values are MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY, WEEKDAY, WEEKEND, or ALL.
        /// </summary>
        [JsonPropertyName("dayOfWeek")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [Required]
        public DayOfWeekEnum DayOfWeeks { get; set; }

        /// <summary>
        /// Gets or sets a boolean value. If set to true, any numbers matching the policy will not be dialed.
        /// </summary>
        [JsonPropertyName("doNotDial")]
        public bool DoNotDial { get; set; }

        /// <summary>
        /// Gets or sets a boolean value. If set to true, any numbers matching the policy will not have messages left.
        /// </summary>
        [JsonPropertyName("doNotLeaveMessage")]
        public bool DoNotLeaveMessage { get; set; }

        /// <summary>
        /// Gets or sets the state where the policy applies.
        /// Possible values include any state two-letter abbreviation.
        /// </summary>
        [JsonPropertyName("state")]
        [MaxLength(2)]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the area code where the policy applies.
        /// </summary>
        [JsonPropertyName("areaCode")]
        public string AreaCode { get; set; }

        /// <summary>
        /// Gets or sets the start time for the region and day(s) defined.
        /// If dialing is allowed, contacts will not start before this time.
        /// If not included, the policy is in effect for the entire day(s) defined in dayOfWeek.
        /// </summary>
        [JsonPropertyName("startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time for the region and day(s) defined.
        /// If dialing is allowed, contacts will not be allowed after this time.
        /// If not included, the policy is in effect for the entire day(s) defined in dayOfWeek.
        /// </summary>
        [JsonPropertyName("endTime")]
        public string EndTime { get; set; }
    }
}
