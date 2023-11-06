using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Contact.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ConditionType
    {
        [JsonPropertyName("STARTS_WITH")]
        StartsWith = 0,

        [JsonPropertyName("ENDS_WITH")]
        EndsWith = 1,

        [JsonPropertyName("EQUALS")]
        Equals = 2,

        [JsonPropertyName("LESS")]
        Less = 3,

        [JsonPropertyName("GREATER")]
        Greater = 4,

        [JsonPropertyName("GREATER_EQUAL")]
        GreaterEqual = 5,

        [JsonPropertyName("CONTAINS")]
        Contains = 6
    }
}
