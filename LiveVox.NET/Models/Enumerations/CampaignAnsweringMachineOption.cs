using System.Text.Json.Serialization;

namespace LiveVox.NET.Models.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AnsweringMachineOption
    {
        [JsonPropertyName("LEAVE_MESSAGES")]
        LeaveMessages, // Detects answering machines and leaves a message.

        [JsonPropertyName("NO_MESSAGES")]
        NoMessages,    // If an answering machine is detected, no message is left, and the call is disconnected.

        [JsonPropertyName("TRANSFER")]
        Transfer       // Answering machine detection is off. All connections are passed to agents.
    }
}
