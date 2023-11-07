using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class TermCodeCategory
    {
        /// <summary>
        /// Term code category name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// A sequence of zero or more term codes.
        /// </summary>
        [JsonPropertyName("termCodes")]
        public List<TermCode> TermCodes { get; set; }
    }
}
