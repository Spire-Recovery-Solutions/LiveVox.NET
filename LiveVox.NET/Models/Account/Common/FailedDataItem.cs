using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Account.Common
{
    public class FailedDataItem
    {
        /// <summary>
        /// Gets or sets the item name (e.g., "ContactId").
        /// </summary>
        [JsonPropertyName("itemName")]
        public string ItemName { get; set; }

        /// <summary>
        /// Gets or sets the cause of failure.
        /// </summary>
        [JsonPropertyName("cause")]
        public string Cause { get; set; }
    }
}
