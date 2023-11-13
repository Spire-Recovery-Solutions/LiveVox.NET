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

namespace LiveVox.NET.Models.Compliance.Requests.DncListManagement
{
    public class DeleteDncEntryRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "dnc/{id}";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Delete;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", DncId, ParameterType.UrlSegment);
            
            return Task.FromResult(request);
        }

        public DeleteDncEntryRequest(int dncId)
        {
            DncId = dncId;
        }
        /// <summary>
        /// Gets or sets the ID for the DNC entry to delete.
        /// </summary>
        [Required]
        public int DncId { get; set; }
    }
}
