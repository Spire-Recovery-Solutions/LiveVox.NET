using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Contact
{
    public class CreateContactResponse : ILiveVoxResponse
    {
        /// <summary>
        /// The ID of the newly created contact.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
