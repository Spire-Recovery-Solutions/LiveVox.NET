using LiveVox.NET.Models.Base;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Requests
{
    public class ListCampaignTransactionsRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "campaign";
        [JsonIgnore]
        public string? Resource { get; set; } = "campaigns/{id}/transactionList";
        public Method RequestType { get; set; } = Method.Get;
        
        public Task<RestRequest> BuildRequestAsync()
        {
            
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", CampaignId, ParameterType.UrlSegment);

            request.AddQueryParameter("count", Count.ToString());
            request.AddQueryParameter("offset", Offset.ToString());
            request.AddQueryParameter("extra", Extra.ToString().ToLower());
            request.AddQueryParameter("daysDue", DaysDue.ToString().ToLower());
            request.AddQueryParameter("validOnly", ValidOnly.ToString().ToLower());

            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        /// <summary>
        /// Gets or sets the ID of the active campaign for which you want to return the account transaction list.
        /// </summary>
        public int CampaignId { get; set; }

        /// <summary>
        /// Gets or sets the number of items to return in the list. There is a hard cap of 1000 items.
        /// </summary>
        [Required]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the offset from 0, based on the count, to start listing from.
        /// </summary>
        [Required]
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether you want the response to include values from the account's EXTRA fields.
        /// The EXTRA fields will be populated with Client-specific data elements, as configured when the campaign is created or uploaded into the LiveVox system.
        /// </summary>
        [Required]
        public bool Extra { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether you want the response to include values from the account's DAYS_DUE fields.
        /// Fields will be populated with Client-specific data elements, as configured when the campaign is created or uploaded into the LiveVox system.
        /// </summary>
        [Required]
        public bool DaysDue { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether you want the response to include only valid account transactions.
        /// Invalid account transactions are ones that have a LiveVox Result that is classified as "Not Made".
        /// This includes accounts without a valid phone number, accounts where all the phone numbers are on the Do Not Call list, accounts with missing or bad data, etc.
        /// </summary>
        [Required]
        public bool ValidOnly { get; set; }
    }
}