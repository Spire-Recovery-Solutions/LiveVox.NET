using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Contact.Enumerations;

namespace LiveVox.NET.Models.Contact;

public class Phone
{
    /// <summary>
    /// One of the phone numbers associated with the contact.
    /// </summary>
    [JsonPropertyName("phone")]
    [Required]
    public string PhoneNumber { get; set; }
    
    /// <summary>
    /// Indicates the position of the phone number (For Example, 1, 2, 3...etc.). The position is used for features such as campaign dialing rules. The max number of the ordinal field is 10.
    /// </summary>
    [JsonPropertyName("ordinal")]
    [Required]
    [Range(1, 10)]
    public int Ordinal { get; set; }

    /// <summary>
    /// The LiveVox system blocks dialing to this phone-account combination for the entire day or permanently
    /// </summary>
    [JsonPropertyName("phoneBlock")]
    public PhoneBlock PhoneBlock { get; set; }

    /// <summary>
    /// Used to indicate whether the contact has given consent to SMS their number.
    /// </summary>
    [JsonPropertyName("smsConsent")]
    public bool SmsConsent { get; set; }

    /// <summary>
    /// Used to indicate whether the contact has given consent to dial their cell number.
    /// </summary>
    [JsonPropertyName("cellConsent")]
    public string CellConsent { get; set; }
}