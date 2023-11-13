using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Compliance.Enumerations;

namespace LiveVox.NET.Models.Compliance.Responses.DncListManagement
{
    public class ReadDncResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Gets or sets the ID of the DNC entry.
        /// </summary>
        [JsonPropertyName("id")]
        public int DncId { get; set; }

        /// <summary>
        /// Gets or sets the Client ID the DNC entry belongs to.
        /// </summary>
        [JsonPropertyName("clientId")]
        public int? ClientId { get; set; }

        /// <summary>
        /// Gets or sets the type of DNC entry. Either DAILY or PERMANENT.
        /// </summary>
        [Required]
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DncEntryType Type { get; set; }

        /// <summary>
        /// Gets or sets the Service ID the DNC entry belongs to.
        /// If not present, then the entry is treated as if it applies to all Services for this particular Client.
        /// </summary>
        [JsonPropertyName("serviceId")]
        public int? ServiceId { get; set; }

        /// <summary>
        /// Gets or sets the filename used to create the DNC entry if the entry was created using the import method or automated through a job scheduler job.
        /// </summary>
        [JsonPropertyName("filename")]
        public string Filename { get; set; }

        /// <summary>
        /// Gets or sets the phone number associated with the DNC entry.
        /// At least one phone, account, or zip must be present.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the account information associated with the DNC entry.
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the zip code associated with the DNC entry.
        /// </summary>
        [JsonPropertyName("zip")]
        public string Zip { get; set; }
    }
}
