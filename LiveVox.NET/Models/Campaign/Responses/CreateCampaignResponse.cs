using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Campaign.Responses
{
    public class CreateCampaignResponse : ILiveVoxResponse
    {
        /// <summary>
        /// The ID of the newly created campaign.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
