using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Campaign.AppendCampaign
{
    public class AppendCampaignRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "campaign";
        public string? Resource { get; set; } = "campaigns/{id}/transactions";
        public Method RequestType { get; set; }

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Resource.Replace("{id}", CampaignId.ToString()), RequestType);

            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        /// <summary>
        /// Gets or sets the ID of the campaign to append records to.
        /// </summary>
        public int CampaignId { get; set; }

        public List<CampaignTransaction> Records { get; set; }

        public AppendCampaignRequest()
        {
            Records = new List<CampaignTransaction>();
        }
    }

    /// <summary>
    /// Represents a campaign transaction.
    /// </summary>
    public class CampaignTransaction
    {
        /// <summary>
        /// The account number for the transaction.
        /// </summary>
        [JsonPropertyName("account")]
        [MaxLength(50)]
        public string Account { get; set; }

        /// <summary>
        /// The first name for the transaction.
        /// </summary>
        [JsonPropertyName("firstName")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name for the transaction.
        /// </summary>
        [JsonPropertyName("lastName")]
        [MaxLength(50)]
        public string LastName { get; set; }

        /// <summary>
        /// The primary phone number for the transaction.
        /// </summary>
        [JsonPropertyName("phone1")]
        [Required]
        [MaxLength(32)]
        public string Phone1 { get; set; }

        /// <summary>
        /// The secondary phone number(s) for the transaction, separated by a comma.
        /// </summary>
        [JsonPropertyName("phone2")]
        [MaxLength(450)]
        public string[] Phone2 { get; set; }

        /// <summary>
        /// The date of birth for the transaction in MMDD format.
        /// </summary>
        [JsonPropertyName("dob")]
        [MaxLength(20)]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Email for the transaction.
        /// </summary>
        [JsonPropertyName("email")]
        [MaxLength(50)]
        public string Email { get; set; }

        /// <summary>
        /// The social security number for the transaction (4 or 9 characters).
        /// </summary>
        [JsonPropertyName("ssn")]
        [MaxLength(9)]
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// Can be used to store additional account information.
        /// </summary>
        [JsonPropertyName("lastPaymentDate")]
        public string LastPaymentDate { get; set; }

        /// <summary>
        /// The minimum payment amount for the transaction.
        /// </summary>
        [JsonPropertyName("minimumPaymentAmount")]
        public decimal MinimumPaymentAmount { get; set; }

        /// <summary>
        /// The account number to be TTS'd in the IVR.
        /// </summary>
        [JsonPropertyName("accountToSpeak")]
        [MaxLength(50)]
        public string AccountToSpeak { get; set; }

        /// <summary>
        /// The amount to be TTS'd in the IVR.
        /// </summary>
        [JsonPropertyName("amountToSpeak")]
        public decimal AmountToSpeak { get; set; }

        /// <summary>
        /// Used to store agent login ID.
        /// </summary>
        [JsonPropertyName("extra1")]
        [MaxLength(50)]
        public string Extra1 { get; set; }

        /// <summary>
        /// Can be used to store additional account information.
        /// </summary>
        [JsonPropertyName("extra2")]
        [MaxLength(50)]
        public string Extra2 { get; set; }

        /// <summary>
        /// Can be used to store additional account information.
        /// </summary>
        [JsonPropertyName("extra3")]
        [MaxLength(50)]
        public string Extra3 { get; set; }

        /// <summary>
        /// Can be used to store additional account information.
        /// </summary>
        [JsonPropertyName("extra4")]
        [MaxLength(50)]
        public string Extra4 { get; set; }

        /// <summary>
        /// Can be used to store additional account information.
        /// </summary>
        [JsonPropertyName("extra5")]
        [MaxLength(50)]
        public string Extra5 { get; set; }

        /// <summary>
        /// Used to store Agent's extension.
        /// </summary>
        [JsonPropertyName("extra6")]
        [MaxLength(50)]
        public string Extra6 { get; set; }

        /// <summary>
        /// If messaging is configured, can be used to TTS names.
        /// </summary>
        [JsonPropertyName("extra7")]
        [MaxLength(50)]
        public string Extra7 { get; set; }

        /// <summary>
        /// Can be used to store additional account information.
        /// </summary>
        [JsonPropertyName("extra8")]
        [MaxLength(50)]
        public string Extra8 { get; set; }

        /// <summary>
        /// Used to store the time for a scheduled call back (HH:MM:SS format).
        /// </summary>
        [JsonPropertyName("extra9")]
        [MaxLength(50)]
        public string ScheduledCallBackTime { get; set; }

        /// <summary>
        /// Stores the zip code for the transaction and used for zip area mismatch.
        /// </summary>
        [JsonPropertyName("extra11")]
        [MaxLength(50)]
        public string Extra11 { get; set; }

        /// <summary>
        /// Stores the date of service information.
        /// </summary>
        [JsonPropertyName("extra12")]
        [MaxLength(50)]
        public string Extra12 { get; set; }

        /// <summary>
        /// Can be used to store values; separate with pipes for multiple values.
        /// </summary>
        [JsonPropertyName("extra13")]
        [MaxLength(50)]
        public string Extra13 { get; set; }

        /// <summary>
        /// Can be used to store values; separate with pipes for multiple values.
        /// </summary>
        [JsonPropertyName("extra14")]
        [MaxLength(50)]
        public string Extra14 { get; set; }

        /// <summary>
        /// Can be used to store values; separate with pipes for multiple values.
        /// </summary>
        [JsonPropertyName("extra15")]
        [MaxLength(50)]
        public string Extra15 { get; set; }

        /// <summary>
        /// Can be used to store additional account information.
        /// </summary>
        [JsonPropertyName("extra16")]
        [MaxLength(50)]
        public string Extra16 { get; set; }

        /// <summary>
        /// Can be used to store additional account information.
        /// </summary>
        [JsonPropertyName("extra19")]
        [MaxLength(50)]
        public string Extra19 { get; set; }

        /// <summary>
        /// Can be used to store additional account information.
        /// </summary>
        [JsonPropertyName("extra20")]
        [MaxLength(150)]
        public string Extra20 { get; set; }

        /// <summary>
        /// The original account number for the transaction.
        /// </summary>
        [JsonPropertyName("originalAccountNumber")]
        public string OriginalAccountNumber { get; set; }

        /// <summary>
        /// The practice ID for the transaction.
        /// </summary>
        [JsonPropertyName("practiceId")]
        public int PracticeId { get; set; }

        /// <summary>
        /// The client practice ID for the transaction.
        /// </summary>
        [JsonPropertyName("clientPracticeId")]
        [MaxLength(50)]
        public string ClientPracticeId { get; set; }

        /// <summary>
        /// The template ID that will be used on the call.
        /// </summary>
        [JsonPropertyName("templateId")]
        public string TemplateId { get; set; }

        /// <summary>
        /// The phone number played in the IVR for outbound calls.
        /// </summary>
        [JsonPropertyName("practicePhone")]
        [MaxLength(13)]
        public string PracticePhone { get; set; }

        /// <summary>
        /// The caller ID displayed for outbound calls.
        /// </summary>
        [JsonPropertyName("practicePhoneAlternate")]
        [Required]
        [MaxLength(13)]
        public string PracticePhoneAlternate { get; set; }

        /// <summary>
        /// The operator phone used for the transaction (caller ID on manual dials).
        /// </summary>
        [JsonPropertyName("operatorNumber")]
        [MaxLength(13)]
        public string OperatorNumber { get; set; }

        /// <summary>
        /// Information about specific locations for the sub-client.
        /// </summary>
        [JsonPropertyName("placeOfServiceId")]
        public int PlaceOfServiceId { get; set; }

        /// <summary>
        /// Alternate language a user can choose from in the IVR.
        /// </summary>
        [JsonPropertyName("altLanguage1")]
        public int AltLanguage1 { get; set; }

        /// <summary>
        /// Alternate language a user can choose from in the IVR.
        /// </summary>
        [JsonPropertyName("altLanguage2")]
        public int AltLanguage2 { get; set; }

        /// <summary>
        /// Alternate language a user can choose from in the IVR.
        /// </summary>
        [JsonPropertyName("altLanguage3")]
        public int AltLanguage3 { get; set; }

        /// <summary>
        /// The main language the IVR will be offered in.
        /// </summary>
        [JsonPropertyName("language")]
        public int Language { get; set; }

        /// <summary>
        /// The total amount due.
        /// </summary>
        [JsonPropertyName("totalAmount")]
        public decimal TotalAmount { get; set; }
    }
}