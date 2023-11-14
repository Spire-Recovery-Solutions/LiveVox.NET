using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Call.Enumerations;

namespace LiveVox.NET.Converter
{
    public class ErrorCodeJsonConverter : JsonConverter<ErrorCode>
    {
        public override ErrorCode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.String)
            {
                throw new JsonException();
            }

            var stringValue = reader.GetString();
            return stringValue switch
            {
                "440" => ErrorCode.Busy,
                "486" => ErrorCode.Busy,
                "998" => ErrorCode.OutsideOfAllowableDialingWindow,
                "999" => ErrorCode.OutsideOfAllowableDialingWindow,
                "799" => ErrorCode.NoAgentsAvailableToDial,
                "899" => ErrorCode.InvalidPhoneNumber,
                "900" => ErrorCode.CallDisabled,
                "901" => ErrorCode.CallExceedsQueued,
                "902" => ErrorCode.CallInvalidQueued,
                "1000" => ErrorCode.PhoneNumberOnDNCList,
                "601" => ErrorCode.MaxAttemptsReachedForAccount,
                "602" => ErrorCode.NoAccountInformationAvailable,
                "603" => ErrorCode.AccountAttemptsPKViolation,
                "604" => ErrorCode.AccountUnknownStatus,
                "605" => ErrorCode.AccountDefault,
                "606" => ErrorCode.AccountUndefinedStatus,
                "607" => ErrorCode.AccountNumberOnDNCList,
                "608" => ErrorCode.InvalidDialingSequence,
                "609" => ErrorCode.CampaignNotAvailable,
                "9999" => ErrorCode.CampaignInactive,
                _ => throw new JsonException($"Unknown error code: {stringValue}")
            };
        }

        public override void Write(Utf8JsonWriter writer, ErrorCode value, JsonSerializerOptions options)
        {
            // Write logic, depending on how you want to handle the serialization
            writer.WriteStringValue(value.ToString());
        }
    }

}
