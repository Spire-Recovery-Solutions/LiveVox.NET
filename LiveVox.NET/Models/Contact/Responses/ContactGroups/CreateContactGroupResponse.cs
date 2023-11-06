using LiveVox.NET.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Contact.Responses.Contact_Groups
{
    public class CreateContactGroupResponse: ILiveVoxResponse
    {
        /// <summary>
        /// The ID of the newly created Contact Group
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
