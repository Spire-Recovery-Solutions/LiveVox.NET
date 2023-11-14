using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LiveVox.NET.Models.CallContextData.Common
{
    public class ContextDataEntry
    {
        /// <summary>
        /// The unique identifier for the value
        /// </summary>
        [JsonPropertyName("key")]
        [Required(AllowEmptyStrings = false)]
        public string Key { get; set; }

        /// <summary>
        /// The value associated to the key
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
