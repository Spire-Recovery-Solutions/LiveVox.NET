using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Contact.Common.Contacts;
using LiveVox.NET.Models.Contact.Enumerations;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests.Contacts
{
    public class UpdateContactDndRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "contact";
        [JsonIgnore]
        public string? Resource { get; set; } = "contacts/{account}/dnd";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Put;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("account", Account);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        public UpdateContactDndRequest(string account)
        {
            Account = account;
        }

        /// <summary>
        /// Identifier of the account, normally coming from a client's system of record.
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// An array of phone numbers associated with the contact. This key also indicates how the DND settings are updated.
        /// </summary>
        [JsonPropertyName("updateContactDND")]
        public ICollection<Phone> UpdateContactDND { get; set; }

        /// <summary>
        /// Blocks any dialing to this account for the entire day or permanently
        /// </summary>
        [JsonPropertyName("accountBlock")]
        public DialBlockOption AccountBlock { get; set; }
    }
}
