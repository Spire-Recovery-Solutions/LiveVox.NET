using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Contact.Common.Contacts
{
    public class ExportableField
    {
        /// <summary>
        /// Fields that you would like to be exported. If the user provides the keyword "allFields", then all fields will be returned.
        /// ExportField enum can be used here
        /// </summary>
        public string ExportField { get; set; }
    }
}
