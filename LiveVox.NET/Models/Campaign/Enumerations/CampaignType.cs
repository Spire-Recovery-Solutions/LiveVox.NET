using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CampaignType
    {
        /// <summary>
        /// An outbound campaign.
        /// </summary>
        [JsonPropertyName("1")]
        Outbound,

        /// <summary>
        /// An SMS campaign.
        /// </summary>
        [JsonPropertyName("6")]
        SMS,

        /// <summary>
        /// An HCI (Human-Computer Interaction) campaign.
        /// </summary>
        [JsonPropertyName("7")]
        HCI,

        /// <summary>
        /// A DMT (Digital Media and Technology) campaign.
        /// </summary>
        [JsonPropertyName("8")]
        DMT,
    }
}