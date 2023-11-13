using System.Text.Json.Serialization;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Account.Enumerations;
using LiveVox.NET.Models.Account.Requests;
using LiveVox.NET.Models.Account.Responses;
using LiveVox.NET.Models.Call.Enumerations;
using LiveVox.NET.Models.Call.Enumerations.Agent;
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
using LiveVox.NET.Models.Call.Responses.Agent.CallControl;
using LiveVox.NET.Models.Call.Requests.Agent.CallControl;
using LiveVox.NET.Models.Call.Requests.Agent.Chat;
using LiveVox.NET.Models.Call.Requests.Agent.PreviewDial;
using LiveVox.NET.Models.Call.Requests.Agent.Status;
using LiveVox.NET.Models.Call.Requests.Agent.TransferAndConference;
using LiveVox.NET.Models.Call.Requests.Routing;
using LiveVox.NET.Models.Call.Requests.Supervisor.AgentStatus;
using LiveVox.NET.Models.Call.Requests.Supervisor.Chat;
using LiveVox.NET.Models.Call.Requests.Supervisor.Service;
using LiveVox.NET.Models.Call.Requests.SupervisorCalls;
using LiveVox.NET.Models.Call.Responses.Agent.Chat;
using LiveVox.NET.Models.Call.Responses.Agent.Message;
using LiveVox.NET.Models.Call.Responses.Agent.Service;
using LiveVox.NET.Models.Call.Responses.Agent.Status;
using LiveVox.NET.Models.Call.Responses.Agent.TransferAndConference;
using LiveVox.NET.Models.Call.Responses.Agent.Voicemail;
using LiveVox.NET.Models.Call.Responses.Routing;
using LiveVox.NET.Models.Call.Responses.Supervisor.AgentStatus;
using LiveVox.NET.Models.Call.Responses.Supervisor.Chat;
using LiveVox.NET.Models.Call.Responses.Supervisor.Monitor;
using LiveVox.NET.Models.Call.Responses.Supervisor.Service;
using LiveVox.NET.Models.Call.Responses.SupervisorCalls;
using ChangeToNotReadyRequest = LiveVox.NET.Models.Call.Requests.Supervisor.AgentStatus.ChangeToNotReadyRequest;
using ChangeToReadyRequest = LiveVox.NET.Models.Call.Requests.Supervisor.AgentStatus.ChangeToReadyRequest;

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
    [JsonSerializable(typeof(GetAreaCodeResponse))]
    [JsonSerializable(typeof(ActionType))]
    [JsonSerializable(typeof(FeatureCode))]
    [JsonSerializable(typeof(LineNumber))]
    [JsonSerializable(typeof(LineState))]
    [JsonSerializable(typeof(MessageLanguage))]
    [JsonSerializable(typeof(ReasonCode))]
    [JsonSerializable(typeof(ScheduleCallbackOptions))]
    [JsonSerializable(typeof(TimeZone))]
    [JsonSerializable(typeof(CallInQueueStatus))]
    [JsonSerializable(typeof(ErrorCode))]
    [JsonSerializable(typeof(ManualDialExRequest))]
    [JsonSerializable(typeof(ManualDialRequest))]
    [JsonSerializable(typeof(SaveTermCodeRequest))]
    [JsonSerializable(typeof(CreateChatChannelRequest))]
    [JsonSerializable(typeof(FindChannelRequest))]
    [JsonSerializable(typeof(SendPostToChannelRequest))]
    [JsonSerializable(typeof(DialPreviewDialRequest))]
    [JsonSerializable(typeof(AgentToAgentTransferRequest))]
    [JsonSerializable(typeof(GetAvailableAgentListRequest))]
    [JsonSerializable(typeof(ManualTransferRequest))]
    [JsonSerializable(typeof(PhonebookTransferRequest))]
    [JsonSerializable(typeof(CallbackRequest))]
    [JsonSerializable(typeof(RouteToAgentRequest))]
    [JsonSerializable(typeof(ChangeToNotReadyRequest))]
    [JsonSerializable(typeof(ChangeToReadyRequest))]
    [JsonSerializable(typeof(LogoffAgentsRequest))]
    [JsonSerializable(typeof(BroadcastChatMessageRequest))]
    [JsonSerializable(typeof(GetChatMessageRequest))]
    [JsonSerializable(typeof(SendChatMessageRequest))]
    [JsonSerializable(typeof(SwitchServiceRequest))]
    [JsonSerializable(typeof(LaunchManualCallsRequest))]
    [JsonSerializable(typeof(ScheduleCallbackRequest))]
    [JsonSerializable(typeof(GetAreaCodeResponse))]
    [JsonSerializable(typeof(GetScreenPopDetailsResponse))]
    [JsonSerializable(typeof(GetTermCodeResponse))]
    [JsonSerializable(typeof(CreateChatChannelResponse))]
    [JsonSerializable(typeof(FindChannelResponse))]
    [JsonSerializable(typeof(ListPostsResponse))]
    [JsonSerializable(typeof(ListRecentChannelsResponse))]
    [JsonSerializable(typeof(GetMessagesResponse))]
    [JsonSerializable(typeof(GetAgentDesktopStatsResponse))]
    [JsonSerializable(typeof(GetDetailsResponse))]
    [JsonSerializable(typeof(GetServiceDetailsResponse))]
    [JsonSerializable(typeof(GetAgentStatusResponse))]
    [JsonSerializable(typeof(GetAvailableAgentListResponse))]
    [JsonSerializable(typeof(GetCallCenterListResponse))]
    [JsonSerializable(typeof(GetPhonebookDetailsExtResponse))]
    [JsonSerializable(typeof(GetPhonebookDetailsResponse))]
    [JsonSerializable(typeof(CheckVoicemailResponse))]
    [JsonSerializable(typeof(GetHoldQueueStatusResponse))]
    [JsonSerializable(typeof(GetRouteStatusResponse))]
    [JsonSerializable(typeof(RouteToAgentResponse))]
    [JsonSerializable(typeof(ChangeToNotReadyResponse))]
    [JsonSerializable(typeof(ChangeToReadyResponse))]
    [JsonSerializable(typeof(LogoffAgentsResponse))]
    [JsonSerializable(typeof(BroadcastChatMessageResponse))]
    [JsonSerializable(typeof(GetChatMessageResponse))]
    [JsonSerializable(typeof(StartOrGetMonitorCallResponse))]
    [JsonSerializable(typeof(GetServicesAllowedResponse))]
    [JsonSerializable(typeof(SwitchServiceResponse))]
    [JsonSerializable(typeof(GetNonAttemptedManualCallsResponse))]
    [JsonSerializable(typeof(GetQueueStatsResponse))]
    [JsonSerializable(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
    public partial class LiveVoxSerializerContext : JsonSerializerContext
    {
        // The source generator will fill in the necessary code here.
    }
}
