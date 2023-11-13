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
        public ICollection<DncEntry> Dnc { get; set; }

        /// <summary>
        /// Gets or sets a URI for the next page of entries. If not present or blank, there are no pages after this one.
        /// </summary>
        public Uri Next { get; set; }
    }
}
