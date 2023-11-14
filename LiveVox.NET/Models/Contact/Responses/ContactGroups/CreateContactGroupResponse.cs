using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Contact.Responses.ContactGroups
{
    public class CreateContactGroupResponse: ILiveVoxResponse
    {
        /// <summary>
        /// The ID of the newly created Contact Group
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
