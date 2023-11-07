using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CampaignStatus
    {
        /// <summary>
        /// Campaign is unassigned.
        /// </summary>
        [JsonPropertyName("UNASSIGNED")]
        Unassigned,

        /// <summary>
        /// Campaign is active.
        /// </summary>
        [JsonPropertyName("ACTIVE")]
        Active,

        /// <summary>
        /// Campaign is prebuilt.
        /// </summary>
        [JsonPropertyName("PREBUILT")]
        Prebuilt,

        /// <summary>
        /// Campaign is currently playing.
        /// </summary>
        [JsonPropertyName("PLAYING")]
        Playing,

        /// <summary>
        /// Campaign is paused.
        /// </summary>
        [JsonPropertyName("PAUSED")]
        Paused,

        /// <summary>
        /// Campaign is stopped.
        /// </summary>
        [JsonPropertyName("STOPPED")]
        Stopped,

        /// <summary>
        /// Campaign is completed.
        /// </summary>
        [JsonPropertyName("COMPLETED")]
        Completed,

        /// <summary>
        /// Campaign is invalid.
        /// </summary>
        [JsonPropertyName("INVALID")]
        Invalid
    }
}