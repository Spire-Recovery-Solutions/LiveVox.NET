using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Call.Enumerations.Agent;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class LineDetails
    {
        /// <summary>
        /// Valid values are: ACD, DIRECT, EXT1,.... EXT20
        /// </summary>
        [JsonPropertyName("lineNumber")]
        public LineNumber LineNumber { get; set; }

        /// <summary>
        /// Name of the extension.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Flag to indicate if a prerecorded audio message is being played to the caller.
        /// </summary>
        [JsonPropertyName("playingMessage")]
        public bool PlayingMessage { get; set; }

        /// <summary>
        /// Indicates if the line is active.
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Indicates if the call controls (transfer, volume control, etc) are enabled.
        /// </summary>
        [JsonPropertyName("callControl")]
        public bool CallControl { get; set; }

        /// <summary>
        /// Line's current state
        /// </summary>
        [JsonPropertyName("state")]
        public LineState State { get; set; }

        /// <summary>
        /// Indicates if the Debtor call has hangup.
        /// </summary>
        [JsonPropertyName("customerDisconnectedBeforeBridge")]
        public bool CustomerDisconnectedBeforeBridge { get; set; }

        /// <summary>
        /// Indicates if the conference has initiated.
        /// </summary>
        [JsonPropertyName("conferenceInitiated")]
        public bool ConferenceInitiated { get; set; }

        /// <summary>
        /// Indicates if the Supervisor call is success.
        /// </summary>
        [JsonPropertyName("supervisorCallSuccessBeforeConferenced")]
        public bool SupervisorCallSuccessBeforeConferenced { get; set; }

        /// <summary>
        /// Indicates that the debtor, agent and supervisor/second agent are on conference call.
        /// </summary>
        [JsonPropertyName("callConferenced")]
        public bool CallConferenced { get; set; }

        /// <summary>
        /// Indicates whether the current agent call is being transferred to a queue.
        /// </summary>
        [JsonPropertyName("transferToQueue")]
        public bool TransferToQueue { get; set; }

        /// <summary>
        /// Indicates whether the transfer to queue request failed.
        /// </summary>
        [JsonPropertyName("transferToQueueFailed")]
        public bool TransferToQueueFailed { get; set; }

        /// <summary>
        /// Indicates that call is on hold during the transfer.
        /// </summary>
        [JsonPropertyName("transferCallOnHold")]
        public bool TransferCallOnHold { get; set; }

        /// <summary>
        /// The name of the agent who received the call.
        /// </summary>
        [JsonPropertyName("callTransferredToAgent")]
        public string CallTransferredToAgent { get; set; }

        /// <summary>
        /// Phone number of the Supervisor.
        /// </summary>
        [JsonPropertyName("supervisorPhoneNumber")]
        public string SupervisorPhoneNumber { get; set; }

        /// <summary>
        /// The time the Agent last changed their state.
        /// </summary>
        [JsonPropertyName("stateChangedTime")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset StateChangedTime { get; set; }

        /// <summary>
        /// Holds call details
        /// </summary>
        [JsonPropertyName("call")]
        public CallDetails CallDetails { get; set; }
    }
}
