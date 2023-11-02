using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models
{
    public class IsSessionValidRequest : ILiveVoxRequest
    {
        public IsSessionValidRequest(string sessionId)
        {
            SessionId = sessionId;
        }

        public string? Category { get; set; } = "session";
        public string? Resource { get; set; } = "validate";
        public Method RequestType { get; set; } = Method.Get;
        public string SessionId { get; set; }
    }
}
