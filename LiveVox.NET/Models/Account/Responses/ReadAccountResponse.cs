using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Account.Common;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Account.Responses
{
    public class ReadAccountResponse : Common.Account, ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the unique Account ID.
        /// </summary>
        [JsonPropertyName("id")]
        public int AccountId { get; set; }

        /// <summary>
        /// Gets or sets the creation date of the account in Unix timestamp format.
        /// </summary>
        [JsonPropertyName("createdDate")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the username who created the account.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the most recent modification date of the account in Unix timestamp format.
        /// </summary>
        [JsonPropertyName("modifiedDate")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the username who last modified the account.
        /// </summary>
        [JsonPropertyName("modifiedBy")]
        public string ModifiedBy { get; set; }
        /// <summary>
        /// Gets or sets a list of notes associated with the account.
        /// </summary>
        [JsonPropertyName("notes")]
        public ICollection<Note> Notes { get; set; }

        /// <summary>
        /// Gets or sets a list of contact IDs associated with the account.
        /// </summary>
        [JsonPropertyName("contacts")]
        public ICollection<int> ContactIds { get; set; }

        /// <summary>
        /// Gets or sets the account classification name.
        /// </summary>
        [JsonPropertyName("classificationName")]
        public string ClassificationName { get; set; }

        /// <summary>
        /// Gets or sets the account type name.
        /// </summary>
        [JsonPropertyName("typeName")]
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the name of the agent assigned to the account.
        /// </summary>
        [JsonPropertyName("agentName")]
        public string AgentName { get; set; }

        /// <summary>
        /// Gets or sets the account history.
        /// </summary>
        [JsonPropertyName("history")]
        public AccountHistory History { get; set; }

        /// <summary>
        /// Gets or sets the primary account value.
        /// </summary>
        [JsonPropertyName("primaryAccountContact")]
        public string PrimaryAccountContact { get; set; }

        /// <summary>
        /// Gets or sets the error ID.
        /// </summary>
        [JsonPropertyName("logId")]
        public Guid LogId { get; set; }

        /// <summary>
        /// Gets or sets the error description.
        /// </summary>
        [JsonPropertyName("errorMsg")]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Gets or sets the primary contact information.
        /// </summary>
        [JsonPropertyName("primaryContact")]
        public PrimaryContact PrimaryContactInfo { get; set; }

        /// <summary>
        /// Gets or sets the name of the agent team assigned to the account.
        /// </summary>
        [JsonPropertyName("agentTeamName")]
        public string AgentTeamName { get; set; }
    }
}
