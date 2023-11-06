using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum VoiceTalent
    {
        /// <summary>
        /// Julie voice talent.
        /// </summary>
        [JsonPropertyName("1")]
        Julie = 1,

        /// <summary>
        /// Juanita voice talent.
        /// </summary>
        [JsonPropertyName("2")]
        Juanita = 2,

        /// <summary>
        /// Kate voice talent.
        /// </summary>
        [JsonPropertyName("3")]
        Kate = 3,

        /// <summary>
        /// Gisele voice talent.
        /// </summary>
        [JsonPropertyName("4")]
        Gisele = 4,

        /// <summary>
        /// Bob voice talent.
        /// </summary>
        [JsonPropertyName("5")]
        Bob = 5,

        /// <summary>
        /// GruffM voice talent.
        /// </summary>
        [JsonPropertyName("6")]
        GruffM = 6,

        /// <summary>
        /// GruffF voice talent.
        /// </summary>
        [JsonPropertyName("8")]
        GruffF = 8,

        /// <summary>
        /// Lee voice talent.
        /// </summary>
        [JsonPropertyName("9")]
        Lee = 9,

        /// <summary>
        /// Scarlet voice talent.
        /// </summary>
        [JsonPropertyName("10")]
        Scarlet = 10,

        /// <summary>
        /// Claudine voice talent.
        /// </summary>
        [JsonPropertyName("11")]
        Claudine = 11,
    }
}
