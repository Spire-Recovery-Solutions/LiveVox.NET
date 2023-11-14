using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Enumerations
{
    public enum ErrorCode
    { 
        /// <summary>
        /// Error code 440: Busy
        /// </summary>
        [JsonPropertyName("440")]
        Busy = 440,

        /// <summary>
        /// Error code 486: Busy
        /// </summary>
        [JsonPropertyName("486")]
        Busy1 = 486,

        /// <summary>
        /// Error code 999: Outside of allowable dialing window
        /// </summary>
        [JsonPropertyName("999")]
        OutsideOfAllowableDialingWindow = 999,

        /// <summary>
        /// Error code 998: Outside of allowable dialing window
        /// </summary>
        [JsonPropertyName("998")]
        OutsideOfAllowableDialingWindow1 = 998,

        /// <summary>
        /// Error code 799: No agents available to dial
        /// </summary>
        [JsonPropertyName("799")]
        NoAgentsAvailableToDial = 799,

        /// <summary>
        /// Error code 899: Invalid phone number
        /// </summary>
        [JsonPropertyName("899")]
        InvalidPhoneNumber = 899,

        /// <summary>
        /// Error code 900: Call disabled
        /// </summary>
        [JsonPropertyName("900")]
        CallDisabled = 900,

        /// <summary>
        /// Error code 901: Call exceeds queued
        /// </summary>
        [JsonPropertyName("901")]
        CallExceedsQueued = 901,

        /// <summary>
        /// Error code 902: Call invalid queued
        /// </summary>
        [JsonPropertyName("902")]
        CallInvalidQueued = 902,

        /// <summary>
        /// Error code 1000: Phone number on DNC list
        /// </summary>
        [JsonPropertyName("1000")]
        PhoneNumberOnDNCList = 1000,

        /// <summary>
        /// Error code 601: Max attempts reached for account
        /// </summary>
        [JsonPropertyName("601")]
        MaxAttemptsReachedForAccount = 601,

        /// <summary>
        /// Error code 602: No account information available
        /// </summary>
        [JsonPropertyName("602")]
        NoAccountInformationAvailable = 602,

        /// <summary>
        /// Error code 603: Account attempts PK violation
        /// </summary>
        [JsonPropertyName("603")]
        AccountAttemptsPKViolation = 603,

        /// <summary>
        /// Error code 604: Account unknown status
        /// </summary>
        [JsonPropertyName("604")]
        AccountUnknownStatus = 604,

        /// <summary>
        /// Error code 605: Account default
        /// </summary>
        [JsonPropertyName("605")]
        AccountDefault = 605,

        /// <summary>
        /// Error code 606: Account undefined status
        /// </summary>
        [JsonPropertyName("606")]
        AccountUndefinedStatus = 606,

        /// <summary>
        /// Error code 607: Account number on DNC list
        /// </summary>
        [JsonPropertyName("607")]
        AccountNumberOnDNCList = 607,

        /// <summary>
        /// Error code 9999: Invalid dialing sequence, please contact support
        /// </summary>
        [JsonPropertyName("9999")]
        InvalidDialingSequence = 9999,

        /// <summary>
        /// Error code 9998: Campaign is not available
        /// </summary>
        [JsonPropertyName("9998")]
        CampaignNotAvailable = 9998,

        /// <summary>
        /// Error code 9997: Campaign inactive
        /// </summary>
        [JsonPropertyName("9997")]
        CampaignInactive = 9997
    }
}
