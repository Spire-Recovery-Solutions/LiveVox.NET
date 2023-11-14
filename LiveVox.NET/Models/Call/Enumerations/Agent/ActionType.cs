using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Enumerations.Agent
{
    
    /// <summary>
    /// Represents the action type for term codes.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActionType
    {
        /// <summary>
        /// Right Party Connect - With Payment.
        /// </summary>
        [JsonPropertyName("RPC_WITH_PAYMENT")]
        RightPartyConnectWithPayment = 0,

        /// <summary>
        /// Right Party Connect - Without Payment.
        /// </summary>
        [JsonPropertyName("RPC_WITHOUT_PAYMENT")]
        RightPartyConnectWithoutPayment = 1,

        /// <summary>
        /// Wrong Party Connect.
        /// </summary>
        [JsonPropertyName("WPC")]
        WrongPartyConnect = 2,

        /// <summary>
        /// Other.
        /// </summary>
        [JsonPropertyName("OTHER")]
        Other = 3
    }

}
