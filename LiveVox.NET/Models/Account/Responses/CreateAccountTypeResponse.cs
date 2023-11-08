using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Account.Responses
{
    public class CreateAccountTypeResponse : ILiveVoxResponse
    {
        
        /// <summary>
        /// The ID of the newly created type.
        /// </summary>
        [JsonPropertyName("id")]
        [Required]
        public int Id { get; set; }
    }
}
