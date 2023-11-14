using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Call.Enumerations.Agent;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class Features
    {
        /// <summary>
    /// Gets or sets whether agent notes are enabled.
    /// </summary>
    [JsonPropertyName("agentNotesEnabled")]
    public bool AgentNotesEnabled { get; set; }

    /// <summary>
    /// Gets or sets whether Agent to Agent Transfer options are enabled.
    /// </summary>
    [JsonPropertyName("agentToAgentTransferEnabled")]
    public bool AgentToAgentTransferEnabled { get; set; }

    /// <summary>
    /// Gets or sets whether call recording controllers (pause/resume/stop) are enabled.
    /// </summary>
    [JsonPropertyName("callRecordingControlEnabled")]
    public bool CallRecordingControlEnabled { get; set; }

    /// <summary>
    /// Gets or sets whether not ready break codes are enabled.
    /// </summary>
    [JsonPropertyName("reasonCodesEnabled")]
    public bool ReasonCodesEnabled { get; set; }

    /// <summary>
    /// Gets or sets the feature code of the Livevox ACD mode.
    /// Valid values: 0, 2, 3, 6, 7, 8, 9
    /// </summary>
    [JsonPropertyName("featureCode")]
    public FeatureCode FeatureCode { get; set; }

    /// <summary>
    /// Gets or sets whether an agent has the option to dial manual calls on Agent at Ready Services.
    /// </summary>
    [JsonPropertyName("manualOptionEnabled")]
    public bool ManualOptionEnabled { get; set; }

    /// <summary>
    /// Gets or sets whether the manual option should be presented to an agent in a preview dialog.
    /// </summary>
    [JsonPropertyName("manualPreviewButtonEnabled")]
    public bool ManualPreviewButtonEnabled { get; set; }

    /// <summary>
    /// Gets or sets whether Manual Transfer options are enabled.
    /// </summary>
    [JsonPropertyName("manualTransferEnabled")]
    public bool ManualTransferEnabled { get; set; }

    /// <summary>
    /// Gets or sets an array of reason code values. Valid values are "Break", "Lunch", "Meeting", "Other", "Tech Difficulties", "Training", and "Voice Mail".
    /// </summary>
    [JsonPropertyName("notReadyReasonCodes")]
    public ICollection<ReasonCode> NotReadyReasonCodes { get; set; }

    /// <summary>
    /// Gets or sets whether the Phone book transfer option is enabled.
    /// </summary>
    [JsonPropertyName("phoneBookTransferEnabled")]
    public bool PhoneBookTransferEnabled { get; set; }

    /// <summary>
    /// Gets or sets whether to confirm the dial if an agent chooses to dial the preview account.
    /// </summary>
    [JsonPropertyName("confirmOnPreviewDial")]
    public bool ConfirmOnPreviewDial { get; set; }

    /// <summary>
    /// Gets or sets the default action to perform once the preview timeout expires.
    /// </summary>
    [JsonPropertyName("previewDefaultAction")]
    public string PreviewDefaultAction { get; set; }

    /// <summary>
    /// Gets or sets the time allowed for an agent to make a decision (dial/skip) for a preview call.
    /// </summary>
    [JsonPropertyName("previewTimeout")]
    public int PreviewTimeout { get; set; }

    /// <summary>
    /// Gets or sets the schedule callback options available for a requested Service.
    /// Valid values: 3, 2, "else"
    /// </summary>
    [JsonPropertyName("scheduledCallback")]
    public ScheduleCallbackOptions ScheduledCallback { get; set; }

    /// <summary>
    /// Gets or sets whether an agent is allowed to enter a callback phone number.
    /// </summary>
    [JsonPropertyName("scheduledCallbackPhoneReadOnly")]
    public bool ScheduledCallbackPhoneReadOnly { get; set; }

    /// <summary>
    /// Gets or sets whether an agent is allowed to skip a preview call.
    /// </summary>
    [JsonPropertyName("previewSkipEnabled")]
    public bool PreviewSkipEnabled { get; set; }

    /// <summary>
    /// Gets or sets whether termination codes are enabled.
    /// </summary>
    [JsonPropertyName("termCodeEnabled")]
    public bool TermCodeEnabled { get; set; }

    /// <summary>
    /// Gets or sets whether the ability to transfer a call is enabled.
    /// </summary>
    [JsonPropertyName("transferOptionEnabled")]
    public bool TransferOptionEnabled { get; set; }

    /// <summary>
    /// Gets or sets whether volume control is enabled.
    /// </summary>
    [JsonPropertyName("volumeControlEnabled")]
    public bool VolumeControlEnabled { get; set; }

    /// <summary>
    /// Gets or sets whether the service is LVZ enabled.
    /// </summary>
    [JsonPropertyName("lvzEnabled")]
    public bool LvzEnabled { get; set; }

    /// <summary>
    /// Gets or sets the URL for the Services' ScreenPop.
    /// </summary>
    [JsonPropertyName("lvScreenPopUrl")]
    public string LvScreenPopUrl { get; set; }

    /// <summary>
    /// Gets or sets whether an account number is required.
    /// </summary>
    [JsonPropertyName("strictAccountNumberEnabled")]
    public bool StrictAccountNumberEnabled { get; set; }
    }
}
