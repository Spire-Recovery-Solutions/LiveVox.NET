using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.SupervisorCalls;

namespace LiveVox.NET.Models.Call.Responses.SupervisorCalls
{
    public class GetNonAttemptedManualCallsResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Provides information for each of the transactions requested to dial via LaunchManualCall API that failed to dial.
        /// </summary>
        [JsonPropertyName("nonAttemptedManualCalls")]
        public ICollection<NonAttemptedManualCall> NonAttemptedManualCalls { get; set; }
    }
}
