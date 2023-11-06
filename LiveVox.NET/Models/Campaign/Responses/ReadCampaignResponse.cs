using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Campaign.Common;
using LiveVox.NET.Models.Campaign.Enumerations;

namespace LiveVox.NET.Models.Campaign.Responses
{
    public class ReadCampaignResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Name of the campaign
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type of the campaign. Possible types include:
        /// </summary>
        public CampaignType TypeId { get; set; }

        /// <summary>
        /// The ID of the Service to which the campaign is assigned
        /// </summary>
        public int ServiceId { get; set; }

        /// <summary>
        /// The phone number first dialed by LiveVox when extension-based agents are called by LiveVox to tether them to the system.
        /// It is also the number used as the default caller ID of manual dials.
        /// If an LCID package was used then 'LOCAL' will be returned, and LVP will display [Local, rotated].
        /// </summary>
        public string OperatorPhone { get; set; }

        /// <summary>
        /// The phone number left by the LiveVox system on voicemail or live person messages.
        /// If an LCID package was used then 'LOCAL' will be returned, and LVP will display [Local, rotated].
        /// </summary>
        public string CallbackPhone { get; set; }

        /// <summary>
        /// If true, the campaign is configured to use a local caller ID package as the callbackPhone, callerId, or operatorPhone so that consumers receiving calls will see a local caller ID.
        /// </summary>
        public bool LocalCallerIdPackage { get; set; }

        /// <summary>
        /// The caller ID would be visible on a consumer's phone, or included in the envelope of a voicemail message.
        /// If localCallerIdPackage is true, then callerId will be 'LOCAL', and LVP will display [Local, rotated].
        /// </summary>
        public string CallerId { get; set; }

        /// <summary>
        /// The ID of the Dialing Strategy the LiveVox system will use when dialing account records for the campaign.
        /// </summary>
        public int DialingStrategyId { get; set; }

        /// <summary>
        /// The ID of the voice talent that will be used for the campaign. Possible voice talents are:
        /// </summary>
        public VoiceTalent VoiceId { get; set; }

        /// <summary>
        /// Controls the behavior of the system when an answering machine (voicemail) is detected.
        /// </summary>
        public AnsweringMachineOption AnsweringMachineOption { get; set; }

        /// <summary>
        /// When set to true, cell phones will be dialed as part of the campaign. When set to false, cell phone numbers will be scrubbed from the campaign.
        /// </summary>
        public bool DialCellPhones { get; set; }

        /// <summary>
        /// Describes the status of the campaign.
        /// </summary>
        public CampaignStatus Status { get; set; }

        /// <summary>
        /// Timestamp (Unix timestamp format) describing when the campaign was uploaded to LiveVox.
        /// </summary>
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset UploadDate { get; set; }

        /// <summary>
        /// Timestamp (Unix timestamp format) describing when the campaign was built.
        /// </summary>
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset BuildDate { get; set; }

        /// <summary>
        /// Timestamp (Unix timestamp format) describing the date and time of the record from the campaign that had the earliest call start time (call launch time).
        /// </summary>
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset ActualStartDate { get; set; }

        /// <summary>
        /// Timestamp (Unix timestamp format) describing the date and time of the record from the campaign that had the latest call finish time (call end time).
        /// </summary>
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset ActualEndDate { get; set; }

        /// <summary>
        /// Is null when the campaign schedule is configured. When set to true, it indicates that no campaign schedule has been configured, and the campaign will be built and played on-demand.
        /// </summary>
        public bool OnDemand { get; set; }

        /// <summary>
        /// If included, the campaign will be configured to run on the desired schedule; otherwise, LVP on-demand behavior applies.
        /// </summary>
        public CampaignSchedule ScheduleTime { get; set; }

        /// <summary>
        /// The scrub option returns the value configured for the segmentation option at the Services and Client editor Settings section for the selected service. Below are the available values:
        /// NONE - This is the default option and if selected no scrub occurs.
        /// WIRELESS - Scrubs all wireless phone numbers so that all landline numbers can be dialed.
        /// LANDLINE - Scrubs all landline numbers so that all wireless phone numbers can be dialed.
        /// SEGMENTED_WIRELESS- Scrubs all wireless phone numbers from positions 1-15 and place them starting at position 16.
        /// When loading the campaign, the configured service level Scrub option is automatically taken for the selected service. If the service level Scrub option is selected as null for the particular service, then the client level Scrub option will be taken for that particular service.
        /// </summary>
        public ScrubOption ScrubOption { get; set; }
    }
}
