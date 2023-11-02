using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Session
{
    public class LoginRequest : ILiveVoxRequest
    {
        public string? Category { get; set; }
        public string? Resource { get; set; }
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

    public class LoginResponse : ILiveVoxResponse
    {
        /// <summary>
        /// LiveVox Session ID to be used in subsequent API requests.
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// The ID of the Client corresponding to the clientName provided in the login request.
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// The internal ID of the LiveVox User or Agent corresponding to the userName provided in the login request.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// The number of days until the User or Agents' password expires. This field is optional.
        /// </summary>
        public int? DaysUntilPasswordExpires { get; set; }
    }
}
