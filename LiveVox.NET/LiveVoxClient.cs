using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LiveVox.NET.Models;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Enumerations;
using RestSharp;

namespace LiveVox.NET
{
    public class LiveVoxClient
    {
        private readonly RestClient _restClient;

        private string _sessionId = string.Empty;

        public LiveVoxClient(LiveVoxEnvironment environment, string accessToken, bool useSandbox = false, int maxTimeout = 20000)
        {
           // Use RestSharp to make the authenticated request
            _restClient = new RestClient(
                new RestClientOptions
                {
                    MaxTimeout = maxTimeout,
                    ThrowOnDeserializationError = true,
                    ThrowOnAnyError = true,
                    BaseUrl = environment switch
                    {
                        LiveVoxEnvironment.Na3 => new Uri("https://api.livevox.com"),
                        LiveVoxEnvironment.Na4 => new Uri("https://api.na4.livevox.com"),
                        LiveVoxEnvironment.Na5 => new Uri("https://api.na5.livevox.com"),
                        LiveVoxEnvironment.Na6 => new Uri("https://api.na6.livevox.com"),
                        _ => throw new ArgumentOutOfRangeException(nameof(environment), $"Not expected endpoint value: {environment}")
                    }
                }
            );
        }

        public async Task<T?> SendRequest<T>(ILiveVoxRequest request) where T : class, ILiveVoxResponse
        {
            // Create a RestRequest with the specified endpoint and method
            var restRequest = new RestRequest(request.Category + "/" + request.Resource, request.RequestType);

            //TODO: Auth
            /*
             *
             * An access token is only required on the Session API login request.
             * All other requests made with the resulting session will be tied to the API token provided in the login request for tracking purposes.
             *
             * Request a session id from https://api.livevox.com/session using the Access Token with the header LV-Access
             * Session IDs will expire if there is no activity for 2 hours.
             * Login requests by the same user with the same API Token will return the same Session ID if a valid one already exists.
             * In addition, because Session IDs are tied to the LV-Access token, if a user makes two login requests with different API Tokens, then unique Session IDs will be returned.
             *
             * So we will have to call IsSessionValid and then request a SessionId if it is not true, and append Session Id to the header of all subsequent requests.
             */

            restRequest.AddHeader("LV-Session", _sessionId);

            // Serialize the request using the source-generated context for the specific type of 'request'
            string requestBodyJson = JsonSerializer.Serialize(request, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            restRequest.AddJsonBody(requestBodyJson);

            // Execute the request asynchronously
            var response = await _restClient.ExecuteAsync(restRequest);


            var result = JsonSerializer.Deserialize<T>(response.Content, LiveVoxSerializerContext.Default.Options);
            return result;

        }
    }
}
