using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class VoicemailBox
    {
        /// <summary>
        /// Gets or sets the ID of the voicemail box.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the voicemail box.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the number of voicemails in the box.
        /// </summary>
        [JsonPropertyName("numberOfVoicemails")]
        public int NumberOfVoicemails { get; set; }

        /// <summary>
        /// Gets or sets the type of voicemails.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the storage limit has been reached.
        /// </summary>
        [JsonPropertyName("storageLimitReached")]
        public bool StorageLimitReached { get; set; }
    }
}
