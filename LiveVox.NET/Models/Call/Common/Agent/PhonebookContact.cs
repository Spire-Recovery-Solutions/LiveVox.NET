using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class PhonebookContact
    {
        /// <summary>
        /// Gets or sets the ID of the phonebook contact.
        /// </summary>
        [JsonPropertyName("phoneBookContactId")]
        public int PhoneBookContactId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the phone book.
        /// </summary>
        [JsonPropertyName("phoneBookId")]
        public int PhoneBookId { get; set; }

        /// <summary>
        /// Name of the phone book contact.
        /// 
        /// If the phonebook transfers to a group of agents on LiveVox the contact name will also be followed by information on the state of agents that can accept the phonebook transfer.
        /// The state of agents will be reflected as follows: [H:X/R:X/T:X], where X is the number of agents in each state, H stands for agents on hold, R for agents in ready,
        /// and T for the total number of agents.
        /// </summary>
        [JsonPropertyName("contactName")]
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the contact.
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the extension number.
        /// </summary>
        [JsonPropertyName("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// Indicates whether the phone book contact is routing the calls via internal ACD queue.
        /// </summary>
        [JsonPropertyName("internalQueue")]
        public bool InternalQueue { get; set; }
    }
}
