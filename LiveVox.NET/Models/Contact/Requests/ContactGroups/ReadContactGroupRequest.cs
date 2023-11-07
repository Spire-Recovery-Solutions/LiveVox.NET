using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests.ContactGroups
{
    public class ReadContactGroupRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "contact";
        [JsonIgnore]
        public string? Resource { get; set; } = "contactGroups";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Get;
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("id", Id);
            return Task.FromResult(request);
        }

        public ReadContactGroupRequest(long id)
        {
            Id = id;
        }

        /// <summary>
        /// The ID of the contact group to read. 
        /// </summary>
        public long Id { get; set; }
    }
}
