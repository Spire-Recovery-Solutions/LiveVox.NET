using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Account.Enumerations
{
    /// <summary>
    /// Enumerates the possible types of parent records.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ParentType
    {
        /// <summary>
        /// Represents an account record.
        /// </summary>
        [JsonPropertyName("ACCOUNT")]
        ACCOUNT,

        /// <summary>
        /// Represents a note record.
        /// </summary>
        [JsonPropertyName("NOTE")]
        NOTE,

        /// <summary>
        /// Represents a view record.
        /// </summary>
        [JsonPropertyName("VIEW")]
        VIEW,

        /// <summary>
        /// Represents a ticket record.
        /// </summary>
        [JsonPropertyName("TICKET")]
        TICKET,

        /// <summary>
        /// Represents an opportunity record.
        /// </summary>
        [JsonPropertyName("OPPORTUNITY")]
        OPPORTUNITY,

        /// <summary>
        /// Represents a lead record.
        /// </summary>
        [JsonPropertyName("LEAD")]
        LEAD,

        /// <summary>
        /// Represents an agent record.
        /// </summary>
        [JsonPropertyName("AGENT")]
        AGENT,

        /// <summary>
        /// Represents a user record.
        /// </summary>
        [JsonPropertyName("USER")]
        USER,

        /// <summary>
        /// Represents a contact record.
        /// </summary>
        [JsonPropertyName("CONTACT")]
        CONTACT,

        /// <summary>
        /// Represents a comment record.
        /// </summary>
        [JsonPropertyName("COMMENT")]
        COMMENT
    }
}
