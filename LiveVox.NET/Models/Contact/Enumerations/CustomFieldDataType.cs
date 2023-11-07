using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Contact.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CustomFieldDataType
    {
        [JsonPropertyName("NUMBER")]
        Number = 0,

        [JsonPropertyName("STRING")]
        String = 1,

        [JsonPropertyName("DATE")]
        Date =2,

        [JsonPropertyName("BOOLEAN")]
        Boolean = 3,

        [JsonPropertyName("LIST")]
        List =4
    }
}
