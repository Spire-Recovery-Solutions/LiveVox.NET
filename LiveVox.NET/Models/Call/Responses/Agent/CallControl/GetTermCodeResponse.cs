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
    public class GetTermCodeResponse : ILiveVoxResponse
    {
        /// <summary>
        /// An array of zero or more term code categories.
        /// </summary>
        [JsonPropertyName("termCodeCategories")]
        public ICollection<TermCodeCategory> TermCodeCategories { get; set; }
    }
}
