using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Common
{
    public class ExtraEntry
    {
        /// <summary>
        /// Gets or sets the name of the EXTRA field (e.g. EXTRA_14).
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the value populating the EXTRA field in the account transaction record.
        /// </summary>
        public string Value { get; set; }
    }
}
