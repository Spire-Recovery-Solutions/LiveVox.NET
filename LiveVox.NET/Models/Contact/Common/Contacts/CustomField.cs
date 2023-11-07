using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Contact.Enumerations;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Contact.Common.Contacts
{
    public class CustomField
    {
        /// <summary>
        /// Label for the custom field
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; } 

        /// <summary>
        /// Custom field name where the data will be stored. 
        /// </summary>
        [JsonPropertyName("field")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ContactDetailCustomField Field { get; set; }

        /// <summary>
        /// The value to place into the custom field.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// Possible Values NUMBER, STRING etc.
        /// </summary>
        [JsonPropertyName("dataType")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CustomFieldDataType DataType { get; set; }

        /// <summary>
        /// Only returned if the dataType is 'LIST' and contains the predefined list of values.
        /// </summary>
        [JsonPropertyName("listValues")]
        public ICollection<string> ListValues { get; set; }
    }
}
