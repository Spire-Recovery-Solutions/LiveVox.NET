using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Account.Responses
{
    public class CreateAccountResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the ID of the newly created account.
        /// </summary>
        [JsonPropertyName("id")]
        public int AccountId { get; set; }
    }
}
