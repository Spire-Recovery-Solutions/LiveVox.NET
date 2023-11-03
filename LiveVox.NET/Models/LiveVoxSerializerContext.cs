using System.Text.Json.Serialization;
using LiveVox.NET.Models.Campaign.AppendCampaign;
using LiveVox.NET.Models.Campaign.Common;
using LiveVox.NET.Models.Campaign.CreateCampaign;
using LiveVox.NET.Models.Campaign.Enumerations;
using LiveVox.NET.Models.Session;

namespace LiveVox.NET.Models
{
    [JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, GenerationMode = JsonSourceGenerationMode.Default)]
    [JsonSerializable(typeof(AnsweringMachineOption))]
    [JsonSerializable(typeof(SessionLoginRequest))]
    [JsonSerializable(typeof(SessionLoginResponse))]
    [JsonSerializable(typeof(AppendCampaignRequest))]
    [JsonSerializable(typeof(CreateCampaignRequest))]
    [JsonSerializable(typeof(CreateCampaignResponse))]
    [JsonSerializable(typeof(CampaignType))]
    public partial class LiveVoxSerializerContext : JsonSerializerContext
    {
        // The source generator will fill in the necessary code here.
    }

}
