using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;

namespace LiveVox.NET.Models.Call.Common.SupervisorCalls
{
    public class SupervisorCallsCallEntry
    {
        /// <summary>
        /// Gets or sets the Account Transaction ID associated with a LiveVox campaign.
        /// The Account Transaction ID binds the campaign with an account and one or more phone numbers to dial for that account.
        /// If the transaction ID is missing, LiveVox will create one before launching the call.
        /// </summary>
        [JsonPropertyName("transactionId")]
        public int? TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the phone number to dial.
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the account number of the call.
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the caller ID to use for the call.
        /// </summary>
        [JsonPropertyName("callerId")]
        public string CallerId { get; set; }

        /// <summary>
        /// Gets or sets the template ID to use for the call.
        /// </summary>
        [JsonPropertyName("templateId")]
        public int? TemplateId { get; set; }

        /// <summary>
        /// Gets or sets the time in seconds that a manual call stays active.
        /// If the call does not go out during this time (i.e. there are no agents available to take the call),
        /// it won't be dialed, and the record will be returned in the Get Non Attempted Manual Calls method.
        /// Note: If dialingTimeout is not passed, the call will not have a timeout.
        /// </summary>
        [JsonPropertyName("dialingTimeout")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset DialingTimeout { get; set; }
    }
}
