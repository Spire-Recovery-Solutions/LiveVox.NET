using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Contact.Common;

namespace LiveVox.NET.Models.Contact.Responses
{
    public class ReadContactResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Details of the contact
        /// </summary>
        [JsonPropertyName("readContactDetails")]
        public ContactDetailEntry ContactDetails { get; set; }
    }
}
