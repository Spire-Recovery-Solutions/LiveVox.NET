using System.Text.Json.Serialization;

namespace LiveVox.NET.Models.Contact.Common.Contacts
{
    public class BulkCreateContactDetails : ContactDetails
    {
        /// <summary>
        /// Agent ID.
        /// </summary>
        [JsonPropertyName("agentId")]
        public long? AgentId { get; set; }

        /// <summary>
        /// Department of the contact.
        /// </summary>
        [JsonPropertyName("department")]
        public string? Department { get; set; }

        /// <summary>
        /// Salutation to address the contact.
        /// </summary>
        [JsonPropertyName("salutation")]
        public string Salutation { get; set; }

        /// <summary>
        /// Title of the contact.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// The contact's happiness index.
        /// </summary>
        [JsonPropertyName("happinessIndex")]
        public long? HappinessIndex { get; set; }
    }
}
