using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Session;

public class SessionLoginResponse : ILiveVoxResponse
{
    /// <summary>
    /// LiveVox Session ID to be used in subsequent API requests.
    /// </summary>
    [JsonPropertyName("sessionId")]
    [Required]
    public string SessionId { get; set; }

    /// <summary>
    /// The ID of the Client corresponding to the clientName provided in the login request.
    /// </summary>
    [JsonPropertyName("clientId")]
    [Required]
    public int ClientId { get; set; }

    /// <summary>
    /// The internal ID of the LiveVox User or Agent corresponding to the userName provided in the login request.
    /// </summary>
    [JsonPropertyName("userId")]
    [Required]
    public int UserId { get; set; }

    /// <summary>
    /// The number of days until the User or Agents' password expires.
    /// </summary>
    [JsonPropertyName("daysUntilPasswordExpires")]
    public int? DaysUntilPasswordExpires { get; set; }
}