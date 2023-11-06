using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Common
{
    public class AccountTransactionEntry
    {
        /// <summary>
        /// Gets or sets an object representing a consumer.
        /// </summary>
        [JsonPropertyName("consumer")]
        public Consumer Consumer { get; set; }

        /// <summary>
        /// Gets or sets an array of phone entries for the account.
        /// </summary>
        [JsonPropertyName("phone")]
        public ICollection<PhoneEntry> Phone { get; set; }

        /// <summary>
        /// Gets or sets an array of extra entries from the account transaction record's EXTRA_* fields.
        /// </summary>
        [JsonPropertyName("extra")]
        public ICollection<ExtraEntry> Extra { get; set; }

        /// <summary>
        /// Gets or sets an array of DAYS_DUE entries from the account transaction record's DAYS_DUE_*.
        /// </summary>
        [JsonPropertyName("daysDue")]
        public ICollection<DaysDueEntry> DaysDue { get; set; }

        /// <summary>
        /// Gets or sets the unique account transaction identifier for the account, within the campaign.
        /// </summary>
        [JsonPropertyName("accountTransactionId")]
        public int AccountTransactionId { get; set; }

        /// <summary>
        /// Gets or sets the account identifier, normally coming from the Client's system of record.
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the amount owed by the consumer.
        /// </summary>
        [JsonPropertyName("balance")]
        public decimal Balance { get; set; }

        /// <summary>
        /// Gets or sets the result code assigned to the account transaction by the LiveVox system (aka TFH Result).
        /// </summary>
        [JsonPropertyName("livevoxResultId")]
        public int? LiveVoxResultId { get; set; }

        /// <summary>
        /// Gets or sets the service associated with the account transaction's campaign.
        /// </summary>
        [JsonPropertyName("serviceId")]
        public int ServiceId { get; set; }
    }
}
