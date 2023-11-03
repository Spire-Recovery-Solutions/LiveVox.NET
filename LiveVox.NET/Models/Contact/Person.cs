using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LiveVox.NET.Models.Contact;

public class Person
{
    /// <summary>
    /// First name of the contact.
    /// </summary>
    [JsonPropertyName("firstName")]
    [MaxLength(255)]
    public string FirstName { get; set; }
    
    /// <summary>
    /// Last name of the contact.
    /// </summary>
    [JsonPropertyName("lastName")]
    [MaxLength(255)]
    public string LastName { get; set; }
    
    /// <summary>
    /// Email address of the contact.
    /// </summary>
    [JsonPropertyName("email")]
    [MaxLength(255)]
    public string Email { get; set; }
    
    /// <summary>
    /// The date of birth of the contact (in milliseconds).
    /// The dateOfBirth field accepts both formats (DateTime and String).
    /// </summary>
    [JsonPropertyName("dateOfBirth")]
    public DateTime? DateOfBirth { get; set; }
    
    /// <summary>
    /// The social security number of the contact.
    /// </summary>
    [JsonPropertyName("ssn")]
    [MaxLength(255)]
    public string SSN { get; set; }
    
    /// <summary>
    /// The zipcode of the contact.
    /// </summary>
    [JsonPropertyName("zipCode")]
    [MaxLength(255)]
    public string ZipCode { get; set; }
}