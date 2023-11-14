using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Agent;

namespace LiveVox.NET.Models.Call.Responses.Agent.CallControl
{
    public class GetScreenPopDetailsResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Array of screenpop details
        /// </summary>
        [JsonPropertyName("screenPopRow")]
        public ICollection<ScreenPopDetails> ScreenPopRows { get; set; }
    }
}
