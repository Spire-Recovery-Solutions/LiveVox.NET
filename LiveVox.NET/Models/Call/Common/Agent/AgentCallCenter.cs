using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class AgentCallCenter
    {
        /// <summary>
        /// Call Center ID.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Call Center name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
