using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Compliance.Enumerations;

namespace LiveVox.NET.Models.Compliance.Common
{
    public class DncEntry
    {
        /// <summary>
        /// Gets or sets the internal LiveVox ID of the DNC entry.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Client ID the DNC entry belongs to.
        /// </summary>
        [JsonPropertyName("clientId")]
        public int ClientId { get; set; }

        /// <summary>
        /// Gets or sets the type of the DNC entry (DAILY or PERMANENT).
        /// </summary>
        [JsonPropertyName("dncType")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DncEntryType DncType { get; set; }

        /// <summary>
        /// Gets or sets the Service ID the DNC entry belongs to.
        /// </summary>
        [JsonPropertyName("serviceId")]
        public int? ServiceId { get; set; }

        /// <summary>
        /// Gets or sets the phone number for the DNC entry. At least one phone, account, or zip will be present.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the account for the DNC entry.
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the zip code for the DNC entry.
        /// </summary>
        [JsonPropertyName("zip")]
        public string Zip { get; set; }
    }
}
