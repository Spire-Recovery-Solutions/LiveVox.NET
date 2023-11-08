using System.Text.Json.Serialization;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Account.Enumerations;
using LiveVox.NET.Models.Account.Requests;
using LiveVox.NET.Models.Account.Responses;
using LiveVox.NET.Models.Campaign.Common;
using LiveVox.NET.Models.Campaign.Enumerations;
using LiveVox.NET.Models.Contact.Common.Contacts;
using LiveVox.NET.Models.Contact.Enumerations;
using LiveVox.NET.Models.Contact.Requests.Contact_Groups;
using LiveVox.NET.Models.Contact.Requests.ContactGroups;
using LiveVox.NET.Models.Contact.Requests.Contacts;
using LiveVox.NET.Models.Contact.Requests.CustomField;
using LiveVox.NET.Models.Contact.Responses.Contact_Groups;
using LiveVox.NET.Models.Contact.Responses.ContactGroups;
using LiveVox.NET.Models.Contact.Responses.ContactNotes;
using LiveVox.NET.Models.Contact.Responses.Contacts;
using LiveVox.NET.Models.Contact.Responses.CustomField;
using LiveVox.NET.Models.Campaign.Requests;
using LiveVox.NET.Models.Campaign.Responses;
using LiveVox.NET.Models.Session;

namespace LiveVox.NET.Models
{
    [JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, GenerationMode = JsonSourceGenerationMode.Default)]
    [JsonSerializable(typeof(AnsweringMachineOption))]
    [JsonSerializable(typeof(CustomFieldName))]
    [JsonSerializable(typeof(SecureFieldName))]
    [JsonSerializable(typeof(ParentType))]
    [JsonSerializable(typeof(SortingDirection))]
    [JsonSerializable(typeof(SessionLoginRequest))]
    [JsonSerializable(typeof(SessionLoginResponse))]
    [JsonSerializable(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
    [JsonSerializable(typeof(CreateAccountRequest))]
    [JsonSerializable(typeof(CreateAccountResponse))]
    [JsonSerializable(typeof(CreateMultipleAccountRequest))]
    [JsonSerializable(typeof(CreateMultipleAccountResponse))]
    [JsonSerializable(typeof(ReadAccountRequest))]
    [JsonSerializable(typeof(ReadAccountResponse))]
    [JsonSerializable(typeof(ListAccountRequest))]
    [JsonSerializable(typeof(ListAccountResponse))]
    [JsonSerializable(typeof(SearchAccountRequest))]
    [JsonSerializable(typeof(SearchAccountResponse))]
    [JsonSerializable(typeof(UpdateAccountRequest))]
    [JsonSerializable(typeof(AddNoteToAccountRequest))]
    [JsonSerializable(typeof(DeleteAccountRequest))]
    [JsonSerializable(typeof(LinkAccountToContactRequest))]
    [JsonSerializable(typeof(LinkAccountToMultipleContactsRequest))]
    [JsonSerializable(typeof(LinkAccountToMultipleContactsResponse))]
    [JsonSerializable(typeof(UnlinkAccountFromContactRequest))]
    [JsonSerializable(typeof(CreateClassificationRequest))]
    [JsonSerializable(typeof(CreateClassificationResponse))]
    [JsonSerializable(typeof(ReadClassificationRequest))]
    [JsonSerializable(typeof(ReadClassificationResponse))]
    [JsonSerializable(typeof(ListAllClassificationRequest))]
    [JsonSerializable(typeof(ListAllClassificationResponse))]
    [JsonSerializable(typeof(UpdateClassificationRequest))]
    [JsonSerializable(typeof(DeleteClassificationRequest))]
    [JsonSerializable(typeof(CreateAccountTypeRequest))]
    [JsonSerializable(typeof(CreateAccountTypeResponse))]
    [JsonSerializable(typeof(ReadAccountTypeRequest))]
    [JsonSerializable(typeof(ReadAccountTypeResponse))]
    [JsonSerializable(typeof(ListAllAccountTypeRequest))]
    [JsonSerializable(typeof(ListAllAccountTypeResponse))]
    [JsonSerializable(typeof(UpdateAccountTypeRequest))]
    [JsonSerializable(typeof(DeleteAccountTypeRequest))]
    [JsonSerializable(typeof(CampaignType))]
    [JsonSerializable(typeof(CampaignStatus))]
    [JsonSerializable(typeof(CampaignState))]
    [JsonSerializable(typeof(ScrubOption))]
    [JsonSerializable(typeof(VoiceTalent))]
    [JsonSerializable(typeof(SessionLoginRequest))]
    [JsonSerializable(typeof(SessionLoginResponse))]
    [JsonSerializable(typeof(DialBlockOption))]
    [JsonSerializable(typeof(CreateContactRequest))]
    [JsonSerializable(typeof(CreateContactResponse))]
    [JsonSerializable(typeof(BulkCreateContactRequest))]
    [JsonSerializable(typeof(BulkCreateOrUpdateContactResponse))]
    [JsonSerializable(typeof(SearchContactsRequest))]
    [JsonSerializable(typeof(ListContactsResponse))]
    [JsonSerializable(typeof(ReadContactResponse))]
    [JsonSerializable(typeof(UpdateContactRequest))]
    [JsonSerializable(typeof(BulkUpdateContactRequest))]
    [JsonSerializable(typeof(CreateContactGroupRequest))]
    [JsonSerializable(typeof(CreateContactGroupResponse))]
    [JsonSerializable(typeof(ListContactGroupResponse))]
    [JsonSerializable(typeof(ReadContactGroupResponse))]
    [JsonSerializable(typeof(UpdateContactGroupRequest))]
    [JsonSerializable(typeof(ReadContactNoteResponse))]
    [JsonSerializable(typeof(RuleOperator))]
    [JsonSerializable(typeof(ExportableFieldBulkDownload))]
    [JsonSerializable(typeof(BulkContactDownloadRequest))]
    [JsonSerializable(typeof(UpdateContactDndRequest))]
    [JsonSerializable(typeof(ListCustomFieldResponse))]
    [JsonSerializable(typeof(ReadCustomFieldResponse))]
    [JsonSerializable(typeof(UpdateCustomFieldRequest))]
    [JsonSerializable(typeof(ContactDetailCustomField))]
    [JsonSerializable(typeof(CustomFieldDataType))]
    [JsonSerializable(typeof(SearchContactsResponse))]
    [JsonSerializable(typeof(ConditionType))]
    [JsonSerializable(typeof(SearchConditionContactField))]
    [JsonSerializable(typeof(SearchContactsSortField))]
    [JsonSerializable(typeof(SortOrder))]
    [JsonSerializable(typeof(ListAccountsResponse))]
    [JsonSerializable(typeof(AppendCampaignRequest))]
    [JsonSerializable(typeof(CreateCampaignRequest))]
    [JsonSerializable(typeof(CreateCampaignResponse))]
    [JsonSerializable(typeof(DeactivateCampaignRequest))]
    [JsonSerializable(typeof(SearchCampaignRequest))]
    [JsonSerializable(typeof(SearchCampaignResponse))]
    [JsonSerializable(typeof(SearchFinishedCallRequest))]
    [JsonSerializable(typeof(SearchFinishedCallResponse))]
    [JsonSerializable(typeof(GetCampaignListInfoRequest))]
    [JsonSerializable(typeof(GetCampaignListInfoResponse))]
    [JsonSerializable(typeof(ListCampaignRequest))]
    [JsonSerializable(typeof(ListCampaingnResponse))]
    [JsonSerializable(typeof(ListCampaignTransactionsRequest))]
    [JsonSerializable(typeof(ListCampaignTransactionsResponse))]
    [JsonSerializable(typeof(ReadCampaignRequest))]
    [JsonSerializable(typeof(ReadCampaignResponse))]
    [JsonSerializable(typeof(UpdateCampaignRequest))]
    [JsonSerializable(typeof(UpdateCampaignStateRequest))]
    [JsonSerializable(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
    public partial class LiveVoxSerializerContext : JsonSerializerContext
    {
        // The source generator will fill in the necessary code here.
    }
}
