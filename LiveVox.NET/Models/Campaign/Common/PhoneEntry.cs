using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Common
{
    public class PhoneEntry
    {
        /// <summary>
        /// Gets or sets one of the phone numbers to dial associated with the account.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the position associated with the phone number.
        /// </summary>
        public int Ordinal { get; set; }
    }
}