using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class ScreenPopDetails
    {
        /// <summary>
        /// Name of screenpop field.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// Value of screenpop field.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
