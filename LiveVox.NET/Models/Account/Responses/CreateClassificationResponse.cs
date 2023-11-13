using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Account.Responses
{
    public class CreateClassificationResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the ID of the newly created classification.
        /// </summary>
        [JsonPropertyName("id")]
        public int ClassificationId { get; set; }
    }
}
