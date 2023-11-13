using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Compliance.Common;

namespace LiveVox.NET.Models.Compliance.Responses.DncListManagement
{
    public class ListDncEntriesResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets a container for a page of DNC entries.
        /// </summary>
        public List<DncEntry> Dnc { get; set; }
    }
}
