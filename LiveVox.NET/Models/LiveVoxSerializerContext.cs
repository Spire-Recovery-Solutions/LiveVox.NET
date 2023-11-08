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
    [JsonSerializable(typeof(LinkAccountToMultipleContactsRequest))]
    [JsonSerializable(typeof(LinkAccountToMultipleContactsResponse))]
    [JsonSerializable(typeof(UnlinkAccountFromContactRequest))]
    [JsonSerializable(typeof(CreateClassificationRequest))]
    [JsonSerializable(typeof(CreateClassificationResponse))]
    [JsonSerializable(typeof(ReadClassificationRequest))]
    [JsonSerializable(typeof(ReadClassificationResponse))]
    [JsonSerializable(typeof(ListAllClassificationRequest))]
    [JsonSerializable(typeof(ListAllClassificationResponse))]
    [JsonSerializable(typeof(UpdateClassificationRequest))]
    [JsonSerializable(typeof(DeleteClassificationRequest))]
    [JsonSerializable(typeof(CreateAccountTypeRequest))]
    [JsonSerializable(typeof(CreateAccountTypeResponse))]
    [JsonSerializable(typeof(ReadAccountTypeRequest))]
    [JsonSerializable(typeof(ReadAccountTypeResponse))]
    [JsonSerializable(typeof(ListAllAccountTypeRequest))]
    [JsonSerializable(typeof(ListAllAccountTypeResponse))]
    [JsonSerializable(typeof(UpdateAccountTypeRequest))]
    [JsonSerializable(typeof(DeleteAccountTypeRequest))]
    public partial class LiveVoxSerializerContext : JsonSerializerContext
    {
        // The source generator will fill in the necessary code here.
    }

}
