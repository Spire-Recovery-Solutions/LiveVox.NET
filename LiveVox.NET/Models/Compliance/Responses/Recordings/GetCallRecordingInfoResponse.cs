using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Compliance.Responses.Recordings
{
    public class GetCallRecordingInfoResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the client ID, a unique identifier of the client to which the call recording belongs.
        /// </summary>
        [Required]
        [JsonPropertyName("clientId")]
        public int ClientId { get; set; }

        /// <summary>
        /// Gets or sets the call center ID, a unique identifier of the call center that the agent who was recorded is associated with.
        /// </summary>
        [Required]
        [JsonPropertyName("callCenterId")]
        public int CallCenterId { get; set; }

        /// <summary>
        /// Gets or sets the service ID, a unique identifier of the service to which the agent was logged in when the call was recorded.
        /// </summary>
        [Required]
        [JsonPropertyName("serviceId")]
        public int ServiceId { get; set; }

        /// <summary>
        /// Gets or sets the agent ID, a unique identifier of the agent involved in the recorded call.
        /// </summary>
        [Required]
        [JsonPropertyName("agentId")]
        public int AgentId { get; set; }

        /// <summary>
        /// Gets or sets the campaign ID, a unique identifier of the campaign that the recorded call was part of.
        /// </summary>
        [Required]
        [JsonPropertyName("campaignId")]
        public int CampaignId { get; set; }

        /// <summary>
        /// Gets or sets the account of the consumer whose call was recorded.
        /// </summary>
        [Required]
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the consumer whose call was recorded.
        /// </summary>
        [Required]
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the term code ID, a unique identifier of the term code of the recorded call.
        /// </summary>
        [Required]
        [JsonPropertyName("termCodeId")]
        public int TermCodeId { get; set; }

        /// <summary>
        /// Gets or sets the date and time that the call recording started.
        /// </summary>
        [Required]
        [JsonPropertyName("fromDate")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset FromDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time that the call recording ended.
        /// </summary>
        [Required]
        [JsonPropertyName("toDate")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset ToDate { get; set; }

        /// <summary>
        /// Gets or sets the original account number associated with the call recording.
        /// The original account number will only be returned if you are on Reporting 3.0 or above.
        /// </summary>
        [JsonPropertyName("originalAccountNumber")]
        public string OriginalAccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the duration of the call recording, in seconds.
        /// </summary>
        [Required]
        [JsonPropertyName("duration")]
        public int Duration { get; set; }
    }
}
