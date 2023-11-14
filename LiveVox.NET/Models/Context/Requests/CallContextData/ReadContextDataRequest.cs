using LiveVox.NET.Models.Base;
using RestSharp;
using System.Text.Json.Serialization;

namespace LiveVox.NET.Models.Context.Requests.CallContextData
{
    public class ReadContextDataRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "context";
        [JsonIgnore]
        public string? Resource { get; set; } = "call/{session}/{txId}/{account}";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Get;
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("session", SessionId, ParameterType.UrlSegment);
            request.AddParameter("txId", TransactionId, ParameterType.UrlSegment);
            request.AddParameter("account", Account, ParameterType.UrlSegment);
            if (ClientId != null)
                request.AddQueryParameter("client", ClientId.ToString());

            return Task.FromResult(request);

        }

        public ReadContextDataRequest(string sessionId, int transactionId, string account, int clientId)
        {
            SessionId = sessionId;
            TransactionId = transactionId;
            Account = account;
            ClientId = clientId;
        }

        /// <summary>
        /// The Session ID of the call to be read
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// The Transaction ID of the call to be read
        /// </summary>
        public int TransactionId { get; set; }

        /// <summary>
        /// The Account of the call to be read
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// The ID of the Client the call is associated to
        /// </summary>
        public int? ClientId { get; set; }
    }
}
