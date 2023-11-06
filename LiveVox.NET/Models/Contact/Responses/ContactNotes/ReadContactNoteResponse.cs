using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Contact.Common.ContactNotes;

namespace LiveVox.NET.Models.Contact.Responses.ContactNotes
{
    public class ReadContactNoteResponse : ContactNote, ILiveVoxResponse
    {
        /// <summary>
        /// The session ID of the call the note was created on.
        /// </summary>
        [JsonPropertyName("sessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// The transaction ID where the note was created.
        /// </summary>
        [Required]
        [JsonPropertyName("transactionId")]
        public long TransactionId { get; set; }

        /// <summary>
        /// Date and time the note was created.
        /// </summary>
        [JsonPropertyName("createDate")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset CreateDate { get; set; }

        /// <summary>
        /// Date and time the note was last modified.
        /// </summary>
        [Required]
        [JsonPropertyName("modifiedDate")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset ModifiedDate { get; set; }
    }
}
