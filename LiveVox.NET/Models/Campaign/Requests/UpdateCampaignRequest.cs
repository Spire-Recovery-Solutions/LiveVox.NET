using LiveVox.NET.Models.Campaign.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LiveVox.NET.Models.Campaign.Common;
using RestSharp;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Campaign.Requests
{
    public class UpdateCampaignRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "campaign";
        [JsonIgnore]
        public string? Resource { get; set; } = "campaigns/{id}";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Put;

        public Task<RestRequest> BuildRequestAsync()
        {
            
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", CampaignId, ParameterType.UrlSegment);

            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        /// <summary>
        /// The ID of the campaign to be updated.
        /// </summary>
        public int CampaignId { get; set; }

        /// <summary>
        /// The serviceId this campaign will be assigned to.
        /// </summary>
        [JsonPropertyName("serviceId")]
        public int? serviceId { get; set; }

        /// <summary>
        /// Operator phone to be set for this campaign. This can be a 10-digit number or 'LOCAL' to use an LCID package.
        /// 'LOCAL' can only be used if the Service level setting is set to LOCAL CALLER ID.
        /// </summary>
        [JsonPropertyName("operatorPhone")]
        [MaxLength(10)]
        public string operatorPhone { get; set; }

        /// <summary>
        /// Voice ID to be assigned for this campaign.
        /// </summary>
        [JsonPropertyName("voiceId")]
        public int? voiceId { get; set; }

        /// <summary>
        /// Denotes the answering machine behavior for this campaign.
        /// Possible values are:
        /// LEAVE_MESSAGES: Detects answering machines and leaves a message.
        /// NO_MESSAGES: If an answering machine is detected, no message is left, and the call is disconnected.
        /// TRANSFER: Answering machine detection is off. All connections are passed to agents.
        /// </summary>
        [JsonPropertyName("answeringMachineOption")]
        public AnsweringMachineOption? answeringMachineOption { get; set; }

        /// <summary>
        /// Caller ID to be set for this campaign. This can be a valid 10-digit caller ID configured at the Service level or 'LOCAL' to use an LCID package.
        /// 'LOCAL' can only be used if the Service level setting is set to LOCAL CALLER ID.
        /// </summary>
        [JsonPropertyName("callerId")]
        [MaxLength(10)]
        public string callerId { get; set; }

        /// <summary>
        /// Callback phone to be set for this campaign. This can be a 10-digit number or 'LOCAL' to use an LCID package.
        /// 'LOCAL' can only be used if the Service level setting is set to LOCAL CALLER ID.
        /// </summary>
        [JsonPropertyName("callbackPhone")]
        [MaxLength(10)]
        public string callbackPhone { get; set; }

        /// <summary>
        /// Dialing Strategy Id number assigned for this campaign.
        /// </summary
        [JsonPropertyName("dialingStrategyId")]
        public int? dialingStrategyId { get; set; }

        /// <summary>
        /// Type of campaign. Possible values are:
        /// 1 - Outbound
        /// 6 - SMS
        /// 7 - HCI
        /// 8 - 10DMT
        /// </summary>
        [JsonPropertyName("typeId")]
        public CampaignType? typeId { get; set; }

        /// <summary>
        /// When this element is present, the campaign will be configured to run on the desired schedule.
        /// </summary>
        [JsonPropertyName("scheduleTime")]
        public CampaignSchedule scheduleTime { get; set; }
    }
}
