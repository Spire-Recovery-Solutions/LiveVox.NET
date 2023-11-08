using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Contact.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SortOrder
    {
        [JsonPropertyName("ASc")]
        Asc = 0,

        [JsonPropertyName("DESC")]
        Desc =1
    }
}
