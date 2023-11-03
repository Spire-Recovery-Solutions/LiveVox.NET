using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Common
{
    public class AccountTransactionEntry
    {
        /// <summary>
        /// Gets or sets an object representing a consumer.
        /// </summary>
        public Consumer Consumer { get; set; }

        /// <summary>
        /// Gets or sets an array of phone entries for the account.
        /// </summary>
        public ICollection<PhoneEntry> Phone { get; set; }

        /// <summary>
        /// Gets or sets an array of extra entries from the account transaction record's EXTRA_* fields.
        /// </summary>
        public ICollection<ExtraEntry> Extra { get; set; }

        /// <summary>
        /// Gets or sets an array of DAYS_DUE entries from the account transaction record's DAYS_DUE_*.
        /// </summary>
        public ICollection<DaysDueEntry> DaysDue { get; set; }

        /// <summary>
        /// Gets or sets the unique account transaction identifier for the account, within the campaign.
        /// </summary>
        public int AccountTransactionId { get; set; }

        /// <summary>
        /// Gets or sets the account identifier, normally coming from the Client's system of record.
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the amount owed by the consumer.
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// Gets or sets the result code assigned to the account transaction by the LiveVox system (aka TFH Result).
        /// </summary>
        public int? LiveVoxResultId { get; set; }

        /// <summary>
        /// Gets or sets the service associated with the account transaction's campaign.
        /// </summary>
        public int ServiceId { get; set; }
    }
}
