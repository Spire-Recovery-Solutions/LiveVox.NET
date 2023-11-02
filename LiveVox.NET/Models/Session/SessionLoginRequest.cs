using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Session
{
    public class SessionLoginRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "session";
        public string? Resource { get; set; } = "login";
        public Method RequestType { get; set; }

        // Properties to hold the request data
        /// <summary>
        /// Name of LiveVox Client on whose behalf the session is being created.
        /// This is not the "Display Name" of the Client, but rather the "Client Code" as it appears in the Client Editor screen in the LiveVox Portal GUI.
        /// </summary>
        public string ClientName { get; set; }

        /// <summary>
        /// Name of LiveVox user or Agent on whose behalf the session is being created.
        /// An Agents 'userName' is case insensitive while a Users 'userName' is case sensitive.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Password associated with the Username.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// If set to true the password update is for an Agent.
        /// If not included in the request it defaults to 'false' meaning that the login request is for a User.
        /// </summary>
        public bool IsAgent { get; set; } = false;
    }
}
