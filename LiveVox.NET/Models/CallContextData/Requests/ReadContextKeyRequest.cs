using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.CallContextData.Requests
{
    public class ReadContextKeyRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "context";
        [JsonIgnore]
        public string? Resource { get; set; } = "call/{session}/{txId}/{account}/{key}";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Get;
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("session", SessionId, ParameterType.UrlSegment);
            request.AddParameter("txId", TransactionId, ParameterType.UrlSegment);
            request.AddParameter("account", Account, ParameterType.UrlSegment);
            request.AddParameter("key", Key, ParameterType.UrlSegment);
            if (ClientId != null)
                request.AddQueryParameter("client", ClientId.ToString());

            return Task.FromResult(request);
        }

        public ReadContextKeyRequest(string sessionId, int transactionId, string account, string key, int clientId)
        {
            SessionId = sessionId;
            TransactionId = transactionId;
            Account = account;
            Key = key;
            ClientId = clientId;
        }

        /// <summary>
        ///  The Session ID of the call to be read
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
        /// The key to read
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// The ID of the Client the call is associated to
        /// </summary>
        public int? ClientId { get; set; }
    }
}
