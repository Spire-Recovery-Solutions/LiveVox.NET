using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Call.Common.Supervisor
{
    public class MessagesFilterCriteria
    {
        /// <summary>
        /// Gets or sets the timestamp to filter messages received after.
        /// </summary>
        public DateTimeOffset MessageReceivedAfter { get; set; }

        /// <summary>
        /// Gets or sets a boolean indicating whether to exclude the user's own messages in the response.
        /// </summary>
        public bool ExcludeOwn { get; set; }
    }
}
