using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Contact.Common
{
    public class BulkCreateContactDetails : CreateContactDetails
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
