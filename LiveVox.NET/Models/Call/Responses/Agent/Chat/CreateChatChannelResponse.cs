using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Call.Responses.Agent.Chat
{
    public class CreateChatChannelResponse : ILiveVoxResponse
    {
        /// <summary>
        /// The ID of the chat channel.
        /// </summary>
        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }
    }
}
