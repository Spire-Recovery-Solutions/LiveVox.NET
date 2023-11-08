using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Agent;

namespace LiveVox.NET.Models.Call.Responses.Agent.TransferAndConference
{
    public class GetPhonebookDetailsResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Array of phonebook contacts
        /// </summary>
        [JsonPropertyName("phoneContact")]
        public ICollection<PhonebookContact> PhoneContacts { get; set; }

        /// <summary>
        /// Gets or sets the description of the phone book contact.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the ID of the phonebook.
        /// </summary>
        [JsonPropertyName("phoneBookId")]
        public string PhoneBookId { get; set; }
    }
}
