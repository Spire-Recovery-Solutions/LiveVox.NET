using System.Text.Json.Serialization;
using LiveVox.NET.Models.Campaign.Enumerations;
using LiveVox.NET.Models.Session;

namespace LiveVox.NET.Models
{
    [JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, GenerationMode = JsonSourceGenerationMode.Default)]
    [JsonSerializable(typeof(AnsweringMachineOption))]
    [JsonSerializable(typeof(SessionLoginRequest))]
    [JsonSerializable(typeof(SessionLoginResponse))]
    public partial class LiveVoxSerializerContext : JsonSerializerContext
    {
        // The source generator will fill in the necessary code here.
    }

}
