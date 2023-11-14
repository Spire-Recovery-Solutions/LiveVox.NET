using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Channels;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Call.Responses.Agent.Chat
{
    public class ListRecentChannelsResponse : ILiveVoxResponse
    {
        /// <summary>
        /// An array of channels.
        /// </summary>
        [JsonPropertyName("channels")]
        public ICollection<Common.Agent.Channel> Channels { get; set; }
    }
}
