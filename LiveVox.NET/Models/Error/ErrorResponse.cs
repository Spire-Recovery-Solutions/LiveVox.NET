using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Error
{
    public class ErrorResponse
    {
        /// <summary>
        /// Gets or sets the internal error code that can be associated with the status code to identify the type of error.
        /// </summary>
        [JsonPropertyName("code")]
        public int Code { get; set; }

        /// <summary>
        /// Gets or sets a user-friendly description of the type and possible cause of the error.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
