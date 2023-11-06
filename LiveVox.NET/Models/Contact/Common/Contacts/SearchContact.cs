using System.Text.Json.Serialization;
using LiveVox.NET.Models.Contact.Enumerations;

namespace LiveVox.NET.Models.Contact.Common.Contacts
{
    public class SearchContact
    {
        /// <summary>
        /// The binary operator to join the left and right side of the rule
        /// </summary>
        [JsonPropertyName("rule")]
        public Rule Rule { get; set; }

        /// <summary>
        /// An object that contains the search Rule or Condition for the left side of the rule.
        /// </summary>
        [JsonPropertyName("left")]
        public object Left { get; set; }

        /// <summary>
        /// An object that contains the search Rule or Condition for the right side of the rule.
        /// </summary>
        [JsonPropertyName("right")]
        public object Right { get; set; }

        /// <summary>
        /// If set to true, negates the rule, defaults to false.
        /// When a rule is negated it negates all conditions under that rule as well as negating the rule itself (i.e. changing 'AND' to 'OR'). 
        /// isNegated is applied at the rule level so it does not work for searches with only a condition,
        /// to negate a single condition search you need to include the 'AND' or 'OR' rule.
        /// </summary>
        public bool IsNegated { get; set; }
    }
}
