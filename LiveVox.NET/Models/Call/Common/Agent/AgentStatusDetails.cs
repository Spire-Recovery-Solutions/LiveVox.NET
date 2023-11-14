using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Call.Enumerations.Agent;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class AgentStatusDetails
    {
        /// <summary>
        /// Indicates whether agent call is connected or not.
        /// </summary>
        [JsonPropertyName("agentCallConnected")]
        public bool AgentCallConnected { get; set; }

        /// <summary>
        /// Indicates if the manual call has failed.
        /// </summary>
        [JsonPropertyName("agentManualDialingFailed")]
        public bool AgentManualDialingFailed { get; set; }

        /// <summary>
        /// Indicates if Preview dialing failed.
        /// </summary>
        [JsonPropertyName("previewDialingFailed")]
        public bool PreviewDialingFailed { get; set; }

        /// <summary>
        /// Preview dialing failed error code.
        /// </summary>
        [JsonPropertyName("previewDialingFailedErrorCode")]
        public int PreviewDialingFailedErrorCode { get; set; }
        
        /// <summary>
        /// Error code for agent manual dialing failed.
        /// </summary>
        [JsonPropertyName("agentManualDialingFailedErrorCode")]
        public int AgentManualDialingFailedErrorCode { get; set; }

        /// <summary>
        /// Reason for the failure of manual call.
        /// </summary>
        [JsonPropertyName("agentManualDialingFailedReason")]
        public string AgentManualDialingFailedReason { get; set; }

        /// <summary>
        /// Preview dialing failed reason.
        /// </summary>
        [JsonPropertyName("previewDialingFailedReason")]
        public string PreviewDialingFailedReason { get; set; }

        /// <summary>
        /// Error code for agent call failed.
        /// </summary>
        [JsonPropertyName("agentCallFailedErrorCode")]
        public int AgentCallFailedErrorCode { get; set; }

        /// <summary>
        /// Indicates if agent call failed.
        /// </summary>
        [JsonPropertyName("agentCallFailed")]
        public bool AgentCallFailed { get; set; }

        /// <summary>
        /// Indicates that the voice mail storage limit has reached.
        /// </summary>
        [JsonPropertyName("voicemailStorageLimitReached")]
        public bool VoicemailStorageLimitReached { get; set; }

        /// <summary>
        /// Gives the total number of new voicemails.
        /// </summary>
        [JsonPropertyName("newVoicemailsCount")]
        public int NewVoicemailsCount { get; set; }

        /// <summary>
        /// The reason why an Agent was in Not Ready.
        /// </summary>
        [JsonPropertyName("reasonCode")]
        public ReasonCode ReasonCode { get; set; }

        /// <summary>
        /// Indicates if Agent is on mute.
        /// </summary>
        [JsonPropertyName("agentMuted")]
        public bool AgentMuted { get; set; }

        /// <summary>
        /// Gets or sets an object containing information on the Service the Agent is logged into.
        /// </summary>
        [JsonPropertyName("service")]
        public ServiceDetails ServiceDetails { get; set; }

        /// <summary>
        /// Gets or sets an object containing the Agents' personal voicemail information.
        /// </summary>
        [JsonPropertyName("voicemail")]
        public VoicemailDetails VoicemailDetails { get; set; }

        /// <summary>
        /// Gets or sets an object containing Agent chat sessions.
        /// </summary>
        [JsonPropertyName("chat")]
        public ChatDetails ChatDetails { get; set; }

        /// <summary>
        /// Gets or sets an array of lines available to the Agent and information for those lines.
        /// </summary>
        [JsonPropertyName("lines")]
        public List<LineDetails> LineDetails { get; set; }
    }
}
