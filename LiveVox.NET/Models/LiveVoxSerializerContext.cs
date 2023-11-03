using System.Text.Json.Serialization;
using LiveVox.NET.Models.Campaign.Enumerations;
using LiveVox.NET.Models.Contact;
using LiveVox.NET.Models.Contact.Enumerations;
using LiveVox.NET.Models.Session;

namespace LiveVox.NET.Models
{
    [JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, GenerationMode = JsonSourceGenerationMode.Default)]
    [JsonSerializable(typeof(AnsweringMachineOption))]
    [JsonSerializable(typeof(SessionLoginRequest))]
    [JsonSerializable(typeof(SessionLoginResponse))]
    [JsonSerializable(typeof(AccountBlock))]
    [JsonSerializable(typeof(PhoneBlock))]
    [JsonSerializable(typeof(CreateContactRequest))]
    [JsonSerializable(typeof(CreateContactResponse))]
    public partial class LiveVoxSerializerContext : JsonSerializerContext
    {
        // The source generator will fill in the necessary code here.
    }

}
