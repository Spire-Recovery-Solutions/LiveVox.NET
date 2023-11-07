using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Contact.Enumerations;

namespace LiveVox.NET.Models.Contact.Common.Contacts;

public class SearchContactsSort
{
    [JsonPropertyName("field")]
    [Required]
    [MaxLength(255)]
    public SearchContactsSortField Field { get; set; }

    [JsonPropertyName("order")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Required]
    public SortOrder Order { get; set; }
}