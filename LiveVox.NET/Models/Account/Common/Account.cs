using LiveVox.NET.Converter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Account.Common
{
    public class Account
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

        /// <summary>
        /// Gets or sets the name of the account which can be duplicated.
        /// </summary>
        [JsonPropertyName("name")]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the account.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the industry to which the account belongs.
        /// </summary>
        [JsonPropertyName("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// Gets or sets the annual revenue of the account.
        /// </summary>
        [JsonPropertyName("annualRevenue")]
        public int? AnnualRevenue { get; set; }

        /// <summary>
        /// Gets or sets the phone or fax number.
        /// </summary>
        [JsonPropertyName("phoneFax")]
        public string PhoneFax { get; set; }

        /// <summary>
        /// Gets or sets the billing address of the account.
        /// </summary>
        [JsonPropertyName("billingAddress")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or sets the account's prospect rating.
        /// </summary>
        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        /// <summary>
        /// Gets or sets the office phone number.
        /// </summary>
        [JsonPropertyName("phoneOffice")]
        public string PhoneOffice { get; set; }

        /// <summary>
        /// Gets or sets the alternate phone number.
        /// </summary>
        [JsonPropertyName("phoneAlternate")]
        public string PhoneAlternate { get; set; }

        /// <summary>
        /// Gets or sets the website of the account.
        /// </summary>
        [JsonPropertyName("website")]
        public string Website { get; set; }

        /// <summary>
        /// Gets or sets the ownership type for the account.
        /// </summary>
        [JsonPropertyName("ownershipType")]
        public string OwnershipType { get; set; }

        /// <summary>
        /// Gets or sets the number of employees.
        /// </summary>
        [JsonPropertyName("numOfEmployees")]
        public int? NumOfEmployees { get; set; }

        /// <summary>
        /// Gets or sets the stock ticker symbol for the account.
        /// </summary>
        [JsonPropertyName("tickerSymbol")]
        public string TickerSymbol { get; set; }

        /// <summary>
        /// Gets or sets the shipping address of the account.
        /// </summary>
        [JsonPropertyName("shippingAddress")]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Gets or sets the campaign ID assigned to the account.
        /// </summary>
        [JsonPropertyName("campaignId")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or sets the unique account number assigned to the account within a client.
        /// </summary>
        [JsonPropertyName("accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the unique account number assigned to the account from the originating source.
        /// </summary>
        [JsonPropertyName("originalAccountNumber")]
        public string OriginalAccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the agent ID assigned to the account.
        /// </summary>
        [JsonPropertyName("agentId")]
        public int? AgentId { get; set; }

        /// <summary>
        /// Gets or sets the agent team ID assigned to the account.
        /// </summary>
        [JsonPropertyName("agentTeamId")]
        public int? AgentTeamId { get; set; }

        /// <summary>
        /// Gets or sets the source of the account record.
        /// </summary>
        [JsonPropertyName("accountSource")]
        public string AccountSource { get; set; }

        /// <summary>
        /// Gets or sets the Standard Industrial Classification (SIC) code of the account's main business categorization.
        /// </summary>
        [JsonPropertyName("sicCode")]
        public string SicCode { get; set; }

        /// <summary>
        /// Gets or sets a brief description of an organization's line of business, based on its SIC code.
        /// </summary>
        [JsonPropertyName("sicDesc")]
        public string SicDescription { get; set; }

        /// <summary>
        /// Gets or sets the account classification ID.
        /// </summary>
        [JsonPropertyName("classificationId")]
        public int? ClassificationId { get; set; }

        /// <summary>
        /// Gets or sets custom field values associated with an account.
        /// </summary>
        [JsonPropertyName("customFields")]
        public ICollection<AccountCustomField> CustomFields { get; set; }

        /// <summary>
        /// Gets or sets secure field values associated with an account.
        /// </summary>
        [JsonPropertyName("secureFields")]
        public ICollection<SecureField> SecureFields { get; set; }

        /// <summary>
        /// Gets or sets the account type ID.
        /// </summary>
        [JsonPropertyName("typeId")]
        public int? AccountTypeId { get; set; }
    }
}
