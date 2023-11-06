using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests.ContactGroups
{
    public class ReadContactGroupRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "contact";
        public string? Resource { get; set; } = "contactGroups";
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
