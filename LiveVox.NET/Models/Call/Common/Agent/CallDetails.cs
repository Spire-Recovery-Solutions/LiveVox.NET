using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class CallDetails
    {
        /// <summary>
    /// Gets or sets the Transaction ID of the call.
    /// </summary>
    [JsonPropertyName("callTransactionId")]
    public string CallTransactionId { get; set; }

    /// <summary>
    /// Gets or sets the Session ID of the call.
    /// </summary>
    [JsonPropertyName("callSessionId")]
    public string CallSessionId { get; set; }

    /// <summary>
    /// Gets or sets the Caller's First Name.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or sets the Caller's Last Name.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or sets a flag indicating whether the call requires acceptance.
    /// </summary>
    [JsonPropertyName("callRequiresAcceptance")]
    public bool CallRequiresAcceptance { get; set; }

    /// <summary>
    /// Gets or sets the timeout for call acceptance, after which the call will be automatically marked as Not Accepted.
    /// </summary>
    [JsonPropertyName("callAcceptanceTimeout")]
    public int CallAcceptanceTimeout { get; set; }

    /// <summary>
    /// Gets or sets a flag indicating whether call recording has started.
    /// </summary>
    [JsonPropertyName("callRecordingStarted")]
    public bool CallRecordingStarted { get; set; }

    /// <summary>
    /// Gets or sets the ID of the service of the call.
    /// </summary>
    [JsonPropertyName("serviceId")]
    public int ServiceId { get; set; }

    /// <summary>
    /// Gets or sets the ID of the call center.
    /// </summary>
    [JsonPropertyName("callCenterId")]
    public int CallCenterId { get; set; }

    /// <summary>
    /// Gets or sets the Account Number for the call.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Gets or sets the Caller's Phone Number.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets a flag indicating whether the account number is required while terminating the call.
    /// </summary>
    [JsonPropertyName("accountNumberRequired")]
    public bool AccountNumberRequired { get; set; }
    }
}
