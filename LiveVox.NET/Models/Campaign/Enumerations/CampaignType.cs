using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Enumerations
{
    /// <summary>
    /// Represents an outbound campaign.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CampaignType
    {
        /// <summary>
        /// An outbound campaign.
        /// </summary>
        [JsonPropertyName("1")] Outbound,

        /// <summary>
        /// A callback campaign (i.e., for Inbound calls).
        /// </summary>
        [JsonPropertyName("2")] Callback,

        /// <summary>
        /// A scheduled callback campaign.
        /// </summary>
        [JsonPropertyName("4")] ScheduledCallback,

        /// <summary>
        /// A manual campaign.
        /// </summary>
        [JsonPropertyName("5")] Manual,

        /// <summary>
        /// An SMS campaign.
        /// </summary>
        [JsonPropertyName("6")] SMS,

        /// <summary>
        /// An HCI (Human-Computer Interaction) campaign.
        /// </summary>
        [JsonPropertyName("7")] HCI,

        /// <summary>
        /// A 10DMT (Digital Media and Technology) campaign.
        /// </summary>
        [JsonPropertyName("8")] DMT,

        /// <summary>
        /// A manual SMS campaign.
        /// </summary>
        [JsonPropertyName("9")] ManualSMS,

        /// <summary>
        /// An Inbound SMS campaign.
        /// </summary>
        [JsonPropertyName("10")] InboundSMS,

        /// <summary>
        /// An Email campaign.
        /// </summary>
        [JsonPropertyName("11")] Email,

        /// <summary>
        /// A manual Email campaign.
        /// </summary>
        [JsonPropertyName("12")] ManualEmail,

        /// <summary>
        /// An Inbound Email campaign.
        /// </summary>
        [JsonPropertyName("13")] InboundEmail,

        /// <summary>
        /// A Chat campaign.
        /// </summary>
        [JsonPropertyName("14")] Chat
    }
}