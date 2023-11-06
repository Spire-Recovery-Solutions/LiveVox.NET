using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Contact.Responses.Contacts
{
    public class BulkCreateOrUpdateContactResponse : ILiveVoxResponse
    {
        /// <summary>
        /// On successful completion, returns a message with the number of contacts actually created.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
