using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Enumerations.Agent
{
    public enum LineState
    {
        /// <summary>
        /// The line is in a LOGOFF state.
        /// </summary>
        [JsonPropertyName("LOGOFF")]
        Logoff = 0,

        /// <summary>
        /// The line is in a LOGON state.
        /// </summary>
        [JsonPropertyName("LOGON")]
        Logon = 1,

        /// <summary>
        /// The line is in a READY state.
        /// </summary>
        [JsonPropertyName("READY")]
        Ready = 2,

        /// <summary>
        /// The line is in a NOT READY state.
        /// </summary>
        [JsonPropertyName("NOTREADY")]
        NotReady = 3,

        /// <summary>
        /// The line is in an INCALL state.
        /// </summary>
        [JsonPropertyName("INCALL")]
        InCall = 4,

        /// <summary>
        /// The line is in a WRAPUP state.
        /// </summary>
        [JsonPropertyName("WRAPUP")]
        WrapUp = 5,

        /// <summary>
        /// The line is in a TRANSFERRING state.
        /// </summary>
        [JsonPropertyName("TRANSFERRING")]
        Transferring = 6,

        /// <summary>
        /// The line is in a MANUAL DIAL state.
        /// </summary>
        [JsonPropertyName("MANUALDIAL")]
        ManualDial = 7,

        /// <summary>
        /// The line is in a PREVIEW DIAL state.
        /// </summary>
        [JsonPropertyName("PREVIEWDIAL")]
        PreviewDial = 8,

        /// <summary>
        /// The line is in a DIALING state.
        /// </summary>
        [JsonPropertyName("DIALING")]
        Dialing = 9,

        /// <summary>
        /// The line is in a REGISTERING state.
        /// </summary>
        [JsonPropertyName("REGISTERING")]
        Registering = 10,

        /// <summary>
        /// The line is in a HOLD state.
        /// </summary>
        [JsonPropertyName("HOLD")]
        Hold = 11,

        /// <summary>
        /// The line is in a RESERVED state.
        /// </summary>
        [JsonPropertyName("RESERVED")]
        Reserved = 12
    }
}
