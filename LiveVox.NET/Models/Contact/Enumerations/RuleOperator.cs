using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Contact.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RuleOperator
    {
        [JsonPropertyName("AND")]
        And = 0,

        [JsonPropertyName("OR")]
        Or = 1,
    }
}
