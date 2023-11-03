using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Contact.Common
{
    public class ContactDetailEntry : ContactDetails
    {
        /// <summary>
        /// The number of attempts made to the contact
        /// </summary>
        [JsonPropertyName("callAttemptsToday")]
        public int? CallAttemptsToday { get; set; }

        /// <summary>
        /// The total number of call attempts made to the account by the LiveVox platform over the lifetime of the account.
        /// </summary>
        [JsonPropertyName("callAttemptsTotal")]
        public int? CallAttemptsTotal { get; set; }

        /// <summary>
        /// Date the contact was created.
        /// </summary>
        [JsonPropertyName("createDate")]
        public DateTimeOffset? CreateDate { get; set; }

        /// <summary>
        /// The date/time when the contact was initially loaded into the LiveVox platform.
        /// </summary>
        [JsonPropertyName("initialLoad")]
        public DateTimeOffset? InitialLoad { get; set; }

        /// <summary>
        /// The date/time when the contact was last loaded into the LiveVox platform.
        /// </summary>
        [JsonPropertyName("lastLoad")]
        public DateTimeOffset? LastLoad { get; set; }
            
        /// <summary>
        /// Date the contact was last changed.
        /// </summary>
        [JsonPropertyName("modifyDate")]
        public DateTimeOffset? ModifyDate { get; set; }
    }
}
