using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Account.Common
{
    /// <summary>
    /// Represents a note with a name and description.
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Gets or sets the note name.
        /// </summary>
        [JsonPropertyName("name")]
        public string NoteName { get; set; }

        /// <summary>
        /// Gets or sets the description of the note.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
