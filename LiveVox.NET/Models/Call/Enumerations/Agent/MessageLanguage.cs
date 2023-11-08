using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Enumerations.Agent
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MessageLanguage
    {
        [JsonPropertyName("1")]
        Julie = 0,

        [JsonPropertyName("2")]
        Spanish = 1
    }
}
