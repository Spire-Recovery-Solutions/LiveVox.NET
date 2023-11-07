using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CampaignState
    {
        /// <summary>
        /// Indicates the campaign should be stopped.
        /// </summary>
        [JsonPropertyName("STOP")] STOP,

        /// <summary>
        /// Indicates the campaign should be played.
        /// </summary>
        [JsonPropertyName("PLAY")] PLAY,

        /// <summary>
        /// Indicates the campaign should be paused.
        /// </summary>
        [JsonPropertyName("PAUSE")] PAUSE,

        /// <summary>
        /// Indicates the campaign should be built.
        /// </summary>
        [JsonPropertyName("BUILD")] BUILD
    }
}
