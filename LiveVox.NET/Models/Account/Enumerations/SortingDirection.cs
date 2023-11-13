using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Account.Enumerations
{
    /// <summary>
    /// Represents the sorting direction enumeration.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SortingDirection
    {
        /// <summary>
        /// Indicates ascending order.
        /// </summary>
        [JsonPropertyName("ASC")]
        Ascending,

        /// <summary>
        /// Indicates descending order.
        /// </summary>
        [JsonPropertyName("DESC")]
        Descending
    }
}
