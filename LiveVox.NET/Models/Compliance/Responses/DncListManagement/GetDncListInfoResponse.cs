using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Responses.DncListManagement
{
    public class GetDncListInfoResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the total number of entries in the list.
        /// </summary>
        [JsonPropertyName("size")]
        [Required]
        public int Size { get; set; }

        /// <summary>
        /// Gets or sets the last date & time that the list was updated.
        /// This information might not be available.
        /// This is formatted according to the definition of dateTime in the XML Schema specification.
        /// For JSON responses, it is represented as the number of milliseconds since midnight on January 1, 1970 (GMT).
        /// </summary>
        [JsonPropertyName("lastModified")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset LastModified { get; set; }
    }
}
