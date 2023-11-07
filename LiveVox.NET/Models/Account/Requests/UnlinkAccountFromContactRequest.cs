using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Account.Requests
{
    public class UnlinkAccountFromContactRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "account";
        [JsonIgnore] 
        public string? Resource { get; set; } = "accounts/{id}/contacts/{contactId}";
        [JsonIgnore] 
        public Method RequestType { get; set; } = Method.Delete;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", AccountId, ParameterType.UrlSegment);
            request.AddParameter("contactId", ContactId, ParameterType.UrlSegment);

            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        public UnlinkAccountFromContactRequest(int accountId, string contactId)
        {
            AccountId = accountId;
            ContactId = contactId;
        }

        /// <summary>
        /// Gets or sets the Account ID to be unlinked.
        /// </summary>
        [JsonPropertyName("id")]
        [Required]
        public int AccountId { get; set; }

        /// <summary>
        /// Gets or sets the Contact ID to be unlinked from the account.
        /// </summary>
        [JsonPropertyName("contactId")]
        [Required]
        public string ContactId { get; set; }
    }
}
