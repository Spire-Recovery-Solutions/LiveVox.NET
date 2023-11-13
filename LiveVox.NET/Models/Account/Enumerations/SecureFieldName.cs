using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Account.Enumerations
{
    /// <summary>
    /// Represents the secure field names where data can be stored.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SecureFieldName
    {
        [JsonPropertyName("SECURE1")]
        SECURE1,

        [JsonPropertyName("SECURE2")]
        SECURE2,

        [JsonPropertyName("SECURE3")]
        SECURE3,

        [JsonPropertyName("SECURE4")]
        SECURE4,

        [JsonPropertyName("SECURE5")]
        SECURE5
    }
}
