using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Contact.Enumerations;

namespace LiveVox.NET.Models.Contact.Common.Contacts;

public class Condition
{
    /// <summary>
    /// The contact field used in the search condition. 
    /// </summary>
    [JsonPropertyName("field")]
    [Required]
    [MaxLength(255)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ContactField Field { get; set; }

    [JsonPropertyName("criteria")]
    [Required]
    [MaxLength(255)]
    public string Criteria { get; set; }

    [JsonPropertyName("condition")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Required]
    public ConditionType Type { get; set; }

    [JsonPropertyName("isNegated")]
    public bool IsNegated { get; set; }
}