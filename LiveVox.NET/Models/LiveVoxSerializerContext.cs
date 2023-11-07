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
    [JsonSerializable(typeof(ParentType))]
    [JsonSerializable(typeof(SortingDirection))]
    [JsonSerializable(typeof(SessionLoginRequest))]
    [JsonSerializable(typeof(SessionLoginResponse))]
    [JsonSerializable(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
    [JsonSerializable(typeof(CreateAccountRequest))]
    [JsonSerializable(typeof(CreateAccountResponse))]
    [JsonSerializable(typeof(CreateMultipleAccountRequest))]
    [JsonSerializable(typeof(CreateMultipleAccountResponse))]
    [JsonSerializable(typeof(ReadAccountRequest))]
    [JsonSerializable(typeof(ReadAccountResponse))]
    [JsonSerializable(typeof(ListAccountRequest))]
    [JsonSerializable(typeof(ListAccountResponse))]
    [JsonSerializable(typeof(SearchAccountRequest))]
    [JsonSerializable(typeof(SearchAccountResponse))]
    [JsonSerializable(typeof(UpdateAccountRequest))]
    [JsonSerializable(typeof(AddNoteToAccountRequest))]
    [JsonSerializable(typeof(DeleteAccountRequest))]
    [JsonSerializable(typeof(LinkAccountToContactRequest))]
    public partial class LiveVoxSerializerContext : JsonSerializerContext
    {
        // The source generator will fill in the necessary code here.
    }

}
