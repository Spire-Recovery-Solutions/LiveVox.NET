using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Contact.Responses
{
    public class CreateContactResponse : ILiveVoxResponse
    {
        /// <summary>
        /// The ID of the newly created contact.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
