using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Account.Common
{
    public class SearchCriteria : Account
    {
        /// <summary>
        /// Gets or sets the start date of the date range to return account records which have a 'createdDate' as same or after this date.
        /// It could take Unix timestamp format like 1577858400000 (in milliseconds).
        /// </summary>
        [JsonPropertyName("createdDateStart")]
        public DateTimeOffset? CreatedDateStart { get; set; }

        /// <summary>
        /// Gets or sets the end date of the date range to return account records which have a 'createdDate' as same or before this date.
        /// It could take Unix timestamp format like 1577858400000 (in milliseconds).
        /// </summary>
        [JsonPropertyName("createdDateEnd")]
        public DateTimeOffset? CreatedDateEnd { get; set; }

        /// <summary>
        /// Gets or sets the start date of the date range to return account records which have a 'modifiedDate' as same or after this date.
        /// It could take Unix timestamp format like 1577858400000 (in milliseconds).
        /// </summary>
        [JsonPropertyName("modifiedDateStart")]
        public DateTimeOffset? ModifiedDateStart { get; set; }

        /// <summary>
        /// Gets or sets the end date of the date range to return account records which have a 'modifiedDate' as same or before this date.
        /// It could take Unix timestamp format like 1577858400000 (in milliseconds).
        /// </summary>
        [JsonPropertyName("modifiedDateEnd")]
        public DateTimeOffset? ModifiedDateEnd { get; set; }

        /// <summary>
        /// Gets or sets the minimum annual revenue amount for filtering.
        /// </summary>
        [JsonPropertyName("annualRevenueStart")]
        public int? AnnualRevenueStart { get; set; }

        /// <summary>
        /// Gets or sets the maximum annual revenue amount for filtering.
        /// </summary>
        [JsonPropertyName("annualRevenueEnd")]
        public int? AnnualRevenueEnd { get; set; }

        /// <summary>
        /// Gets or sets an object indicating the attribute to sort by.
        /// </summary>
        [JsonPropertyName("sort")]
        public SortAccount Sort { get; set; }
    }
}
