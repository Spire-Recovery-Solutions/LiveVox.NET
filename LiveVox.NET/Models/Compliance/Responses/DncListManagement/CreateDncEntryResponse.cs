using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Responses.DncListManagement
{
    public class CreateDncEntryResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the ID of the newly created DNC entry.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
