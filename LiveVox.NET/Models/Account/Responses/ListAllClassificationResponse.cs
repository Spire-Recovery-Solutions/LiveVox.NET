using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Account.Common;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Account.Responses
{
    public class ListAllClassificationResponse : ILiveVoxResponse
    {
        /// <summary>
        /// A list of classifications
        /// </summary>
        public ICollection<Classification> Classfications { get; set; }
    }
}
