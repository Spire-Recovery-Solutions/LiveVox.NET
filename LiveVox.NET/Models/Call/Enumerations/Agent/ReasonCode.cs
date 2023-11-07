using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Enumerations.Agent
{
    /// <summary>
    /// Represents reason codes for call termination.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ReasonCode
    {
        /// <summary>
        /// Break.
        /// </summary>
        [JsonPropertyName("Break")]
        Break = 0,

        /// <summary>
        /// Lunch.
        /// </summary>
        [JsonPropertyName("Lunch")]
        Lunch = 1,

        /// <summary>
        /// Meeting.
        /// </summary>
        [JsonPropertyName("Meeting")]
        Meeting = 2,

        /// <summary>
        /// Other.
        /// </summary>
        [JsonPropertyName("Other")]
        Other = 3,

        /// <summary>
        /// Technical Difficulties.
        /// </summary>
        [JsonPropertyName("Tech Difficulties")]
        TechnicalDifficulties = 4,

        /// <summary>
        /// Training.
        /// </summary>
        [JsonPropertyName("Training")]
        Training = 5,

        /// <summary>
        /// Voice Mail.
        /// </summary>
        [JsonPropertyName("Voice Mail")]
        VoiceMail = 6
    }
}
