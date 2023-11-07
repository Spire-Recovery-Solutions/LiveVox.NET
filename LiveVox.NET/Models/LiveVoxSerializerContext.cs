using System.Text.Json.Serialization;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Account.Enumerations;
using LiveVox.NET.Models.Account.Requests;
using LiveVox.NET.Models.Account.Responses;
using LiveVox.NET.Models.Campaign.Enumerations;
using LiveVox.NET.Models.Session;

namespace LiveVox.NET.Models
{
    [JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, GenerationMode = JsonSourceGenerationMode.Default)]
    [JsonSerializable(typeof(AnsweringMachineOption))]
    [JsonSerializable(typeof(CustomFieldName))]
    [JsonSerializable(typeof(SecureFieldName))]
    [JsonSerializable(typeof(SessionLoginRequest))]
    [JsonSerializable(typeof(SessionLoginResponse))]
    [JsonSerializable(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
    [JsonSerializable(typeof(CreateAccountRequest))]
    [JsonSerializable(typeof(CreateAccountResponse))]
    [JsonSerializable(typeof(CreateMultipleAccountRequest))]
    [JsonSerializable(typeof(CreateMultipleAccountResponse))]
    public partial class LiveVoxSerializerContext : JsonSerializerContext
    {
        // The source generator will fill in the necessary code here.
    }

}
