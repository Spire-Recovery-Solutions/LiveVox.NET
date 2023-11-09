using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Supervisor
{
    public class UsersInfo
    {
        /// <summary>
        /// Agent login ID.
        /// </summary>
        [JsonPropertyName("userLoginId")]
        public string AgentLoginId { get; set; }

        /// <summary>
        /// If true, Agent can reply to the message.
        /// </summary>
        [JsonPropertyName("canReply")]
        public bool CanReply { get; set; }
    }
}
