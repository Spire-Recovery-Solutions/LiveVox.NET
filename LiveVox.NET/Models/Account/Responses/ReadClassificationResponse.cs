using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Account.Responses
{
    public class ReadClassificationResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the ID of the classification.
        /// </summary>
        [JsonPropertyName("id")]
        [Required]
        public int ClassificationId { get; set; }

        /// <summary>
        /// Gets or sets the name of the classification.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string ClassificationName { get; set; }

        /// <summary>
        /// Gets or sets a number indicating the sequence in the display.
        /// </summary>
        [JsonPropertyName("level")]
        public int DisplaySequence { get; set; }
    }
}
