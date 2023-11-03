using LiveVox.NET.Models.Campaign.CreateCampaign;
using LiveVox.NET.Models.Campaign.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Common
{
    public class CampaignConfiguration
    {
        /// <summary>
        /// Gets or sets the service ID the campaign will be assigned to.
        /// </summary>
        [JsonPropertyName("serviceId")]
        [Required]
        public int ServiceId { get; set; }

        /// <summary>
        /// Gets or sets the operator phone to be set for this campaign. It can be a 10-digit number or 'LOCAL' to use an LCID package.
        /// </summary>
        [JsonPropertyName("operatorPhone")]
        public string OperatorPhone { get; set; }

        /// <summary>
        /// Gets or sets the Voice ID for one of the available configured voices.
        /// </summary>
        [JsonPropertyName("voiceId")]
        [Required]
        public int VoiceId { get; set; }

        /// <summary>
        /// Gets or sets the answering machine behavior for this campaign.
        /// </summary>
        [JsonPropertyName("answeringMachineOption")]
        [Required]
        public AnsweringMachineOption AnsweringMachineOption { get; set; }

        /// <summary>
        /// Gets or sets the caller ID to be set for this campaign. It can be a valid 10-digit caller ID configured at the Service level or 'LOCAL' to use an LCID package.
        /// </summary>
        [JsonPropertyName("callerId")]
        public string CallerId { get; set; }

        /// <summary>
        /// Gets or sets the callback phone to be set for this campaign. It can be a 10-digit number or 'LOCAL' to use an LCID package.
        /// </summary>
        [JsonPropertyName("callbackPhone")]
        public string CallbackPhone { get; set; }

        /// <summary>
        /// Gets or sets the Dialing Strategy ID number assigned for this campaign.
        /// </summary>
        [JsonPropertyName("dialingStrategyId")]
        [Required]
        public int DialingStrategyId { get; set; }

        /// <summary>
        /// Gets or sets whether a user will be able to add records to a campaign after it has started using the append campaign record method.
        /// </summary>
        [JsonPropertyName("appendable")]
        public bool Appendable { get; set; }

        /// <summary>
        /// Gets or sets the type of the campaign.
        /// </summary>
        [JsonPropertyName("typeId")]
        [Required]
        public CampaignType TypeId { get; set; }

        /// <summary>
        /// Gets or sets the campaign's schedule settings, including start and end dates and whether it should run on the following day.
        /// </summary>
        [JsonPropertyName("scheduleTime")]
        public CampaignSchedule ScheduleTime { get; set; }
    }
}