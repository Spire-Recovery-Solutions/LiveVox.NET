using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Common
{
    public class Consumer
    {
        /// <summary>
        /// Gets or sets the first name of the consumer.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the consumer.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the date of birth of the consumer.
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the email address of the consumer.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the Social Security number of the consumer.
        /// </summary>
        public string Ssn { get; set; }

        /// <summary>
        /// Gets or sets the zip code of the consumer.
        /// </summary>
        public string ZipCode { get; set; }
    }
}