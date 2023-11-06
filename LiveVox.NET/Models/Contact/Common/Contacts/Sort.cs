using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Contact.Enumerations;

namespace LiveVox.NET.Models.Contact.Common.Contacts;

public class Sort
{
    [JsonPropertyName("field")]
    [Required]
    [MaxLength(255)]
    public SortField Field { get; set; }

    [JsonPropertyName("order")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Required]
    public SortOrder Order { get; set; }
}