using System.Text.Json.Serialization;

/// <summary>
/// Represents time zones with associated meanings.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TimeZone
{
    /// <summary>
    /// Coordinated Universal Time (UTC).
    /// </summary>
    [JsonPropertyName("UTC")]
    UTC = 0,

    /// <summary>
    /// Alaska Time (AL).
    /// </summary>
    [JsonPropertyName("AL")]
    AlaskaTime = 1,

    /// <summary>
    /// Chatham Island Time (CHT).
    /// </summary>
    [JsonPropertyName("CHT")]
    ChathamIslandTime = 2,

    /// <summary>
    /// Pacific Time (PT).
    /// </summary>
    [JsonPropertyName("PT")]
    PacificTime = 3,

    /// <summary>
    /// Mountain Time (MT).
    /// </summary>
    [JsonPropertyName("MT")]
    MountainTime = 4,

    /// <summary>
    /// Atlantic Time (AT).
    /// </summary>
    [JsonPropertyName("AT")]
    AtlanticTime = 5,

    /// <summary>
    /// Central Time (CT).
    /// </summary>
    [JsonPropertyName("CT")]
    CentralTime = 6,

    /// <summary>
    /// Hawaii-Aleutian Time (HI).
    /// </summary>
    [JsonPropertyName("HI")]
    HawaiiAleutianTime = 7,

    /// <summary>
    /// United Kingdom Time (UK).
    /// </summary>
    [JsonPropertyName("UK")]
    UnitedKingdomTime = 8,

    /// <summary>
    /// Eastern Time (ET).
    /// </summary>
    [JsonPropertyName("ET")]
    EasternTime = 9,

    /// <summary>
    /// Guam Time (GU).
    /// </summary>
    [JsonPropertyName("GU")]
    GuamTime = 10
}