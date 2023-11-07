using System.Text.Json.Serialization;
using LiveVox.NET.Converter;

namespace LiveVox.NET.Models.Contact.Common.Contacts
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
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset CreateDate { get; set; }

        /// <summary>
        /// The date/time when the contact was initially loaded into the LiveVox platform.
        /// </summary>
        [JsonPropertyName("initialLoad")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset InitialLoad { get; set; }

        /// <summary>
        /// The date/time when the contact was last loaded into the LiveVox platform.
        /// </summary>
        [JsonPropertyName("lastLoad")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset LastLoad { get; set; }
            
        /// <summary>
        /// Date the contact was last changed.
        /// </summary>
        [JsonPropertyName("modifyDate")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset ModifyDate { get; set; }
    }
}
