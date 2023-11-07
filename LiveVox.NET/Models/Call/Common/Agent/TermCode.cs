using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Call.Enumerations.Agent;

namespace LiveVox.NET.Models.Call.Common.Agent
{
    public class TermCode
    {
        /// <summary>
        /// Term code ID.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of term code category.
        /// </summary>
        [JsonPropertyName("name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// ID of TFH Result.
        /// </summary>
        [JsonPropertyName("lvResultId")]
        public string LvResultId { get; set; }

        /// <summary>
        /// Name of TFH Result.
        /// </summary>
        [JsonPropertyName("lvResult")]
        public string LvResult { get; set; }

        /// <summary>
        /// Order of display.
        /// </summary>
        [JsonPropertyName("reportDisplayOrder")]
        public byte ReportDisplayOrder { get; set; }

        /// <summary>
        /// Whether preview dialing is enabled.
        /// </summary>
        [JsonPropertyName("previewDialEnabled")]
        public bool PreviewDialEnabled { get; set; }

        /// <summary>
        /// Action type.
        /// </summary>
        [JsonPropertyName("actionType")]
        public ActionType ActionTypeValue { get; set; }

        /// <summary>
        /// If true, payment amount is required upon selecting a PTP term code.
        /// </summary>
        [JsonPropertyName("paymentAmtRequired")]
        public bool PaymentAmountRequired { get; set; }
    }
}
