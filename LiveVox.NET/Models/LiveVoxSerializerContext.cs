using System.Text.Json.Serialization;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Campaign.Common;
using LiveVox.NET.Models.Campaign.Enumerations;
using LiveVox.NET.Models.Campaign.Requests;
using LiveVox.NET.Models.Campaign.Responses;
using LiveVox.NET.Models.Session;

namespace LiveVox.NET.Models
{
    [JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, GenerationMode = JsonSourceGenerationMode.Default)]
    [JsonSerializable(typeof(AnsweringMachineOption))]
    [JsonSerializable(typeof(CampaignType))]
    [JsonSerializable(typeof(CampaignStatus))]
    [JsonSerializable(typeof(SessionLoginRequest))]
    [JsonSerializable(typeof(SessionLoginResponse))]
    [JsonSerializable(typeof(AppendCampaignRequest))]
    [JsonSerializable(typeof(CreateCampaignRequest))]
    [JsonSerializable(typeof(CreateCampaignResponse))]
    [JsonSerializable(typeof(DeactivateCampaignRequest))]
    [JsonSerializable(typeof(SearchCampaignRequest))]
    [JsonSerializable(typeof(SearchCampaignResponse))]
    [JsonSerializable(typeof(SearchFinishedCallRequest))]
    [JsonSerializable(typeof(SearchFinishedCallResponse))]
    [JsonSerializable(typeof(GetCampaignListInfoRequest))]
    [JsonSerializable(typeof(GetCampaignListInfoResponse))]
    [JsonSerializable(typeof(ListCampaignRequest))]
    [JsonSerializable(typeof(ListCampaingnResponse))]
    [JsonSerializable(typeof(ListCampaignTransactionsRequest))]
    [JsonSerializable(typeof(ListCampaignTransactionsResponse))]
    [JsonSerializable(typeof(ReadCampaignRequest))]
    [JsonSerializable(typeof(ReadCampaignResponse))]
    [JsonSerializable(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
    public partial class LiveVoxSerializerContext : JsonSerializerContext
    {
        // The source generator will fill in the necessary code here.
    }
}
