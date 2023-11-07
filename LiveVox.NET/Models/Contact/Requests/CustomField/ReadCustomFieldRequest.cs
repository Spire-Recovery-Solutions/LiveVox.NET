using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests.CustomField
{
    public class ReadCustomFieldRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "contact";
        [JsonIgnore]
        public string? Resource { get; set; } = "contacts/customFields";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Get;
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("field", Field);
            return Task.FromResult(request);
        }

        public ReadCustomFieldRequest(string field)
        {
            Field = field;
        }

        /// <summary>
        /// Field name assigned to the custom field. This is the COL1-COL100 field name not the label of the field.
        /// </summary>
        public string Field { get; set; }
    }
}
