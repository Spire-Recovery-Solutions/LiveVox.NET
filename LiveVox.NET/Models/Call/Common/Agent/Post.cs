using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class Post
    {
        /// <summary>
        /// The identifier for this post.
        /// </summary>
        [JsonPropertyName("postId")]
        public string PostId { get; set; }

        /// <summary>
        /// Name of the sender of this item.
        /// </summary>
        [JsonPropertyName("fromName")]
        public string FromName { get; set; }

        /// <summary>
        /// The identifier of the sender of this item.
        /// </summary>
        [JsonPropertyName("fromId")]
        public long FromId { get; set; }

        /// <summary>
        /// Content of the post.
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// Indicator of whether this post has been read by the recipient agent.
        /// </summary>
        [JsonPropertyName("unread")]
        public bool Unread { get; set; }

        /// <summary>
        /// The time at which the post was sent.
        /// </summary>
        [JsonPropertyName("timestamp")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset Timestamp { get; set; }
    }
}
