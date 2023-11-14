using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Call.Enumerations;

namespace LiveVox.NET.Models.Call.Common.SupervisorCalls
{
    public class NonAttemptedManualCall
    {
        /// <summary>
        /// Gets or sets the Account Transaction ID associated with a LiveVox campaign.
        /// The Account Transaction ID binds the campaign with an account and one or more phone numbers to dial for that account.
        /// </summary>
        [JsonPropertyName("transactionId")]
        public int TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the phone number that was sent along with the transactionId via LaunchManualCall API.
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the reason for not attempting the transaction.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets a unique error code representing various reasons for not attempting the transaction.
        /// </summary>
        [JsonPropertyName("errorCode")]
        [JsonConverter(typeof(ErrorCodeJsonConverter))]
        public ErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the transaction received an error.
        /// </summary>
        [JsonPropertyName("timeOfFailure")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset TimeOfFailure { get; set; }
    }
}
