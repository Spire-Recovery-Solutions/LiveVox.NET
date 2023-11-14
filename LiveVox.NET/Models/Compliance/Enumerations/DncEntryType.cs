using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Compliance.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DncEntryType
    {
        /// <summary>
        /// Indicates a daily DNC entry type.
        /// </summary>
        DAILY,

        /// <summary>
        /// Indicates a permanent DNC entry type.
        /// </summary>
        PERMANENT,

        /// <summary>
        /// Indicates a None DNC entry type.
        /// </summary>
        NONE
    }
}
