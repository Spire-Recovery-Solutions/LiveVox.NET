using System.Text.Json.Serialization;

namespace LiveVox.NET.Models.Call.Enumerations.Agent
{
    /// <summary>
    /// Represents the line number options for accepting a call by an Agent.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LineNumber
    {
        /// <summary>
        /// Main line or debtor line.
        /// </summary>
        [JsonPropertyName("ACD")]
        Acd = 0,

        /// <summary>
        /// Direct line for the Agent.
        /// </summary>
        [JsonPropertyName("DIRECT")]
        Direct = 1,

        /// <summary>
        /// Extension line if supported. Use EXT1 to EXT20 for specific extensions.
        /// </summary>
        [JsonPropertyName("EXT1")]
        Ext1 = 2,

        [JsonPropertyName("EXT2")]
        Ext2 = 3,

        [JsonPropertyName("EXT3")]
        Ext3 = 4,

        [JsonPropertyName("EXT4")]
        Ext4 = 5,

        [JsonPropertyName("EXT5")]
        Ext5 = 6,

        [JsonPropertyName("EXT6")]
        Ext6 = 7,

        [JsonPropertyName("EXT7")]
        Ext7 = 8,

        [JsonPropertyName("EXT8")]
        Ext8 = 9,

        [JsonPropertyName("EXT9")]
        Ext9 = 10,

        [JsonPropertyName("EXT10")]
        Ext10 = 11,

        [JsonPropertyName("EXT11")]
        Ext11 = 12,

        [JsonPropertyName("EXT12")]
        Ext12 = 13,

        [JsonPropertyName("EXT13")]
        Ext13 = 14,

        [JsonPropertyName("EXT14")]
        Ext14 = 15,

        [JsonPropertyName("EXT15")]
        Ext15 = 16,

        [JsonPropertyName("EXT16")]
        Ext16 = 17,

        [JsonPropertyName("EXT17")]
        Ext17 = 18,

        [JsonPropertyName("EXT18")]
        Ext18 = 19,

        [JsonPropertyName("EXT19")]
        Ext19 = 20,

        [JsonPropertyName("EXT20")]
        Ext20 = 21
    }
}
