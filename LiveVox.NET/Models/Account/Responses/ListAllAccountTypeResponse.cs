using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveVox.NET.Models.Account.Common;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Account.Responses
{
    public class ListAllAccountTypeResponse : ILiveVoxResponse
    {
        /// <summary>
        /// A list of types
        /// </summary>
        public ICollection<AccountClassification> AccountTypes { get; set; }
    }
}
