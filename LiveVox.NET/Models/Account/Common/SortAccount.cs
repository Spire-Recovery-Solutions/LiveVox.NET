using LiveVox.NET.Models.Account.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Account.Common
{
    public class SortAccount
    {
        /// <summary>
        /// Gets or sets the sorting direction, which can be "ASC" (ascending) or "DESC" (descending).
        /// </summary>
        [JsonPropertyName("direction")]
        public SortingDirection SortingDirection { get; set; }

        /// <summary>
        /// Gets or sets the attribute by which to sort the account records.
        /// </summary>
        [JsonPropertyName("property")]
        public string SortingProperty { get; set; }
    }
}
