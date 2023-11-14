using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Compliance.Common
{
    public class ServiceEntry
    {
        /// <summary>
        /// Gets or sets the LiveVox ID of the Service.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
