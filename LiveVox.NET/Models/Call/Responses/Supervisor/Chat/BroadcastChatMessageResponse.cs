using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Supervisor;

namespace LiveVox.NET.Models.Call.Responses.Supervisor.Chat
{
    public class BroadcastChatMessageResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets an array of Agent IDs indicating if the message was sent successfully.
        /// </summary>
        [JsonPropertyName("broadcastStatus")]
        public ICollection<BroadcastStatus> BroadcastStatus { get; set; }

    }
}
