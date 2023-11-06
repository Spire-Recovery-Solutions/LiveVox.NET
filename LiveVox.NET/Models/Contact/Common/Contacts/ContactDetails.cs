using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Contact.Enumerations;

namespace LiveVox.NET.Models.Contact.Common.Contacts;

public class ContactDetails
{
    /// <summary>
    /// Identifier of the account, normally coming from a Client's system of record.
    /// </summary>
    [JsonPropertyName("account")]
    [MaxLength(255)]
    [Required(AllowEmptyStrings = false)]
    public string Account { get; set; }
    
    /// <summary>
    /// The balance of the contact.
    /// </summary>
    [JsonPropertyName("balance")]
    public double? Balance { get; set; }

    /// <summary>
    /// The LiveVox system blocks any dialing to this account for the entire day (Daily Do Not Dial) or permanently (Permanent Do Not Dial) depending on the following values.
    /// </summary>
    [JsonPropertyName("accountBlock")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DialBlockOption? AccountBlock { get; set; }

    /// <summary>
    /// Information pertaining to the contact owner.
    /// </summary>
    [JsonPropertyName("person")]
    public Person Person { get; set; }

    /// <summary>
    /// Information pertaining to the guarantor of the contact.
    /// </summary>
    [JsonPropertyName("guarantor")]
    public Guarantor Guarantor { get; set; }

    /// <summary>
    /// Phone numbers associated with the contact.
    /// </summary>
    [JsonPropertyName("phone")]
    public  ICollection<Phone> Phone { get; set; }

    /// <summary>
    /// Used to TTS the account number in the IVR.
    /// </summary>
    [JsonPropertyName("accountToSpeak")]
    [MaxLength(255)]
    public string AccountToSpeak { get; set; }

    /// <summary>
    /// Original account number of the contact.
    /// </summary>
    [JsonPropertyName("originalAccountNumber")]
    [MaxLength(255)]
    public string OriginalAccountNumber { get; set; }
    
    /// <summary>
    /// Main street address of the contact.
    /// </summary>
    [JsonPropertyName("address1")]
    [MaxLength(255)]
    public string Address1 { get; set; }
    
    /// <summary>
    /// Alternate street address of the contact.
    /// </summary>
    [JsonPropertyName("address2")]
    [MaxLength(255)]
    public string Address2 { get; set; }
    
    /// <summary>
    /// City of the contact's address.
    /// </summary>
    [JsonPropertyName("city")]
    [MaxLength(255)]
    public string City { get; set; }
    
    /// <summary>
    /// State of the contact's address.
    /// </summary>
    [JsonPropertyName("state")]
    [MaxLength(255)]
    public string State { get; set; }
    
    /// <summary>
    /// Country of the contact's address.
    /// To see the list of countries, use the List Countries Method in Client API.
    /// </summary>
    [JsonPropertyName("country")]
    [MaxLength(255)]
    public string Country { get; set; }
    
    /// <summary>
    /// Used to TTS the amount due in the IVR.
    /// </summary>
    [JsonPropertyName("amountToSpeak")]
    public double? AmountToSpeak { get; set; }
    
    /// <summary>
    /// Date when the account balance is due.
    /// </summary>
    [JsonPropertyName("dueDate")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Group ID to which the contact belongs.
    /// </summary>
    [JsonPropertyName("groupId")]
    public int? GroupId { get; set; }

    /// <summary>
    /// If set to true, indicates that the account is active in the LiveVox system; if not included property will default to false.
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    ///// <summary>
    ///// Custom field values associated with a contact.
    ///// </summary>
    //[JsonPropertyName("customFields")]
    // public ICollection<CustomField> CustomFields { get; set; }
    
    /// <summary>
    /// Used to indicate whether the contact has given consent to receive e-mail.
    /// </summary>
    [JsonPropertyName("primaryEmailConsent")]
    public bool? PrimaryEmailConsent { get; set; }
}