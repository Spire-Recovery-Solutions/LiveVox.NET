using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Campaign.Common
{
    public class CampaignFile
    {
        /// <summary>
        /// Gets or sets the attachment representing the campaign file.
        /// </summary>
        public Attachment CampaignFileAttachment { get; set; }
    }
}