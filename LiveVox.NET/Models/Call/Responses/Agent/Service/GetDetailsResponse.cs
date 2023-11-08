using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Agent;

namespace LiveVox.NET.Models.Call.Responses.Agent.Service
{
    public class GetDetailsResponse : ILiveVoxResponse
    {
         /// <summary>
    /// Gets or sets the phone number for Agent At Ready In Services, which the agent dials.
    /// </summary>
    [JsonPropertyName("callInPhoneNumber")]
    public string CallInPhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets details of the features currently available to the agent.
    /// </summary>
    [JsonPropertyName("features")]
    [Required]
    public Features Features { get; set; }

    /// <summary>
    /// Gets or sets the PIN number for Agent At Ready In Services.
    /// </summary>
    [JsonPropertyName("callInPinNumber")]
    public string CallInPinNumber { get; set; }

    /// <summary>
    /// Gets or sets whether an agent should be provided with login instructions.
    /// </summary>
    [JsonPropertyName("provideInstructions")]
    public bool ProvideInstructions { get; set; }

    /// <summary>
    /// Gets or sets the Client ID.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or sets the Client code.
    /// </summary>
    [JsonPropertyName("clientCode")]
    public string ClientCode { get; set; }

    /// <summary>
    /// Gets or sets the Service ID.
    /// </summary>
    [JsonPropertyName("serviceId")]
    public string ServiceId { get; set; }

    /// <summary>
    /// Gets or sets the description of the Service.
    /// </summary>
    [JsonPropertyName("serviceDescription")]
    public string ServiceDescription { get; set; }

    /// <summary>
    /// Gets or sets the Call Center ID.
    /// </summary>
    [JsonPropertyName("callCenterId")]
    public int CallCenterId { get; set; }

    /// <summary>
    /// Gets or sets the Call Center Name.
    /// </summary>
    [JsonPropertyName("callCenterName")]
    public string CallCenterName { get; set; }
    }
}
