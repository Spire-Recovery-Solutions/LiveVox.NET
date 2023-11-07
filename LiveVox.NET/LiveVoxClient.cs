using System.Net;
using System.Text.Json;
using LiveVox.NET.Models;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Base.Enumerations;
using RestSharp;

namespace LiveVox.NET
{
    public class LiveVoxClient
    {
        private readonly string _accessToken;
        private readonly RestClient _restClient;

        private readonly string _sessionId = string.Empty;
        private DateTimeOffset _lastSessionUseTimestamp = DateTimeOffset.MinValue;

        public LiveVoxClient(LiveVoxEnvironment environment, string accessToken, int maxTimeout = 20000)
        {
            _accessToken = accessToken;
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
            //Session IDs will expire if there is no activity for 2 hours
            if (DateTimeOffset.UtcNow > _lastSessionUseTimestamp.AddHours(-2))
            {
                var sessionValidRequest = await LiveVoxRequestFactory.Session.IsSessionValid(_sessionId).BuildRequestAsync();
                sessionValidRequest.AddHeader("LV-Access", _accessToken);
                var sessionValidResponse = await _restClient.ExecuteAsync(sessionValidRequest);
                if (sessionValidResponse.StatusCode != HttpStatusCode.NoContent) //Session Invalid
                {
                    //TODO: Call Login
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
                }
            }

            // Create a RestRequest with the specified endpoint and method
            var restRequest = await request.BuildRequestAsync();
            
            restRequest.AddHeader("LV-Session", _sessionId);


            // Execute the request asynchronously
            var response = await _restClient.ExecuteAsync(restRequest);

            //TODO: Build out specific error for SDK and handle API Error Responses
            if (!response.IsSuccessStatusCode) return null;

            _lastSessionUseTimestamp = DateTimeOffset.UtcNow;
            var result = JsonSerializer.Deserialize<T>(response.Content, LiveVoxSerializerContext.Default.Options);
            return result;

        }
    }
}
