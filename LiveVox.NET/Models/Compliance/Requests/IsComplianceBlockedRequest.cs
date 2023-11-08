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

namespace LiveVox.NET.Models.Compliance.Requests
{
    public class IsComplianceBlockedRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "complianceCheck/isBlocked";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("client", ClientId.ToString());
            request.AddQueryParameter("service", ServiceId.ToString());
            request.AddQueryParameter("phone", Phone);
            request.AddQueryParameter("account", Account);
            request.AddQueryParameter("zip", Zip);

            return Task.FromResult(request);
        }
        
        /// <summary>
        /// Gets or sets the Client ID that identifies which Client the query pertains to.
        /// </summary>
        public int? ClientId { get; set; }

        /// <summary>
        /// Gets or sets the Service ID. If provided, DNC entries for this particular Service are checked in addition to the "generic" Client ones.
        /// </summary>
        [Required]
        public int ServiceId { get; set; }

        /// <summary>
        /// Gets or sets the phone number to check for compliance.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the account identifier to include in the compliance check.
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the ZIP code to include in the compliance check.
        /// </summary>
        public string Zip { get; set; }
    }
}
