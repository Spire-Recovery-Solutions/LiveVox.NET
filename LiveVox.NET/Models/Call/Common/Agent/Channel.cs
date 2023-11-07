using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class Channel
    {
        /// <summary>
        /// The ID of the channel.
        /// </summary>
        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }

        /// <summary>
        /// Name of the channel that contains the first and last name of the agent who created the channel and the first and last name of the agent who received the channel.
        /// The channel name does not update if agent names are updated after they have created the channel.
        /// </summary>
        [JsonPropertyName("channelName")]
        public string ChannelName { get; set; }

        /// <summary>
        /// Number of unread dialogue entries.
        /// </summary>
        [JsonPropertyName("unreadCount")]
        public int UnreadCount { get; set; }

        /// <summary>
        /// Type of channel.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The ID of the other user (agent) if the agent is a single party.
        /// </summary>
        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        /// <summary>
        /// Full name of the other user (agent) if the agent is a single party.
        /// </summary>
        [JsonPropertyName("userName")]
        public string UserName { get; set; }

        /// <summary>
        /// When the last post was posted.
        /// </summary>
        [JsonPropertyName("lastPostTimestamp")]
        public DateTimeOffset LastPostTimestamp { get; set; }
    }
}
