using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Contact.Responses
{
    public class BulkCreateContactResponse : ILiveVoxResponse
    {
        /// <summary>
        /// On successful completion, returns a message with the number of contacts actually created.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
