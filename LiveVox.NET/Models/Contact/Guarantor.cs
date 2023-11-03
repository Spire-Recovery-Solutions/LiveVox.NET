using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LiveVox.NET.Models.Contact;

public class Guarantor
{
    /// <summary>
    /// First name of the guarantor.
    /// </summary>
    [JsonPropertyName("firstName")]
    [MaxLength(255)]
    public string FirstName { get; set; }
    
    /// <summary>
    /// Last name of the guarantor.
    /// </summary>
    [JsonPropertyName("lastName")]
    [MaxLength(255)]
    public string LastName { get; set; }
}