using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Contact.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExportableFieldBulkDownload
    {
        [JsonPropertyName("allFields")]
        AllFields = 0,

        [JsonPropertyName("account")]
        Account = 1,

        [JsonPropertyName("dueDate")]
        DueDate = 2,

        [JsonPropertyName("accountToSpeak")]
        AccountToSpeak = 3,

        [JsonPropertyName("address1")]
        Address1 = 4,

        [JsonPropertyName("address2")]
        Address2 = 5,

        [JsonPropertyName("agentId")]
        AgentId = 6,

        [JsonPropertyName("agentTeamId")]
        AgentTeamId = 7,

        [JsonPropertyName("amountToSpeak")]
        AmountToSpeak = 8,

        [JsonPropertyName("active")]
        Active = 9,

        [JsonPropertyName("callAttemptsTotal")]
        CallAttemptsTotal = 10,

        [JsonPropertyName("callAttemptsToday")]
        CallAttemptsToday = 11,

        [JsonPropertyName("city")]
        City = 12,

        [JsonPropertyName("clientId")]
        ClientId = 13,

        [JsonPropertyName("countryId")]
        CountryId = 14,

        [JsonPropertyName("createDate")]
        CreateDate = 15,

        [JsonPropertyName("createUser")]
        CreateUser = 16,

        [JsonPropertyName("department")]
        Department = 17,

        [JsonPropertyName("description")]
        Description = 18,

        [JsonPropertyName("dateOfBirth")]
        DateOfBirth = 19,

        [JsonPropertyName("accountBlock")]
        AccountBlock = 20,

        [JsonPropertyName("accountBlockDaily")]
        AccountBlockDaily = 21,

        [JsonPropertyName("accountEmailBlock")]
        AccountEmailBlock = 22,

        [JsonPropertyName("email")]
        Email = 23,

        [JsonPropertyName("firstName")]
        FirstName = 24,

        [JsonPropertyName("groupId")]
        GroupId = 25,

        [JsonPropertyName("guarantorFirstName")]
        GuarantorFirstName = 26,

        [JsonPropertyName("guarantorLastName")]
        GuarantorLastName = 27,

        [JsonPropertyName("initialLoadCampaignId")]
        InitialLoadCampaignId = 28,

        [JsonPropertyName("initialLoadDate")]
        InitialLoadDate = 29,

        [JsonPropertyName("lastLoadCampaignId")]
        LastLoadCampaignId = 30,

        [JsonPropertyName("lastLoadDate")]
        LastLoadDate = 31,

        [JsonPropertyName("lastName")]
        LastName = 32,

        [JsonPropertyName("lvAccountId")]
        LvAccountId = 33,

        [JsonPropertyName("modifyDate")]
        ModifyDate = 34,

        [JsonPropertyName("modifyUser")]
        ModifyUser = 35,

        [JsonPropertyName("originalAccountNumber")]
        OriginalAccountNumber = 36,

        [JsonPropertyName("balance")]
        Balance = 37,

        [JsonPropertyName("phone1")]
        Phone1 = 38,

        [JsonPropertyName("phone1AttemptsTotal")]
        Phone1AttemptsTotal = 39,

        [JsonPropertyName("phone1AttemptsToday")]
        Phone1AttemptsToday = 40,

        [JsonPropertyName("phone1CellConsent")]
        Phone1CellConsent = 41,

        [JsonPropertyName("phone1Block")]
        Phone1Block = 42,

        [JsonPropertyName("phone1BlockDaily")]
        Phone1BlockDaily = 43,

        [JsonPropertyName("phone1SmsConsent")]
        Phone1SmsConsent = 44,

        [JsonPropertyName("phone2")]
        Phone2 = 45,

        [JsonPropertyName("phone2AttemptsTotal")]
        Phone2AttemptsTotal = 46,

        [JsonPropertyName("phone2AttemptsToday")]
        Phone2AttemptsToday = 47,

        [JsonPropertyName("phone2CellConsent")]
        Phone2CellConsent = 48,

        [JsonPropertyName("phone2Block")]
        Phone2Block = 49,

        [JsonPropertyName("phone2BlockDaily")]
        Phone2BlockDaily = 50,

        [JsonPropertyName("phone2SmsConsent")]
        Phone2SmsConsent = 51,

        [JsonPropertyName("phone3")]
        Phone3 = 52,

        [JsonPropertyName("phone3AttemptsTotal")]
        Phone3AttemptsTotal = 53,

        [JsonPropertyName("phone3AttemptsToday")]
        Phone3AttemptsToday = 54,

        [JsonPropertyName("phone3CellConsent")]
        Phone3CellConsent = 55,

        [JsonPropertyName("phone3Block")]
        Phone3Block = 56,

        [JsonPropertyName("phone3BlockDaily")]
        Phone3BlockDaily = 57,

        [JsonPropertyName("phone3SmsConsent")]
        Phone3SmsConsent = 58,

        [JsonPropertyName("phone4")]
        Phone4 = 59,

        [JsonPropertyName("phone4AttemptsTotal")]
        Phone4AttemptsTotal = 60,

        [JsonPropertyName("phone4AttemptsToday")]
        Phone4AttemptsToday = 61,

        [JsonPropertyName("phone4CellConsent")]
        Phone4CellConsent = 62,

        [JsonPropertyName("phone4Block")]
        Phone4Block = 63,

        [JsonPropertyName("phone4BlockDaily")]
        Phone4BlockDaily = 64,

        [JsonPropertyName("phone4SmsConsent")]
        Phone4SmsConsent = 65,

        [JsonPropertyName("phone5")]
        Phone5 = 66,

        [JsonPropertyName("phone5AttemptsTotal")]
        Phone5AttemptsTotal = 67,

        [JsonPropertyName("phone5AttemptsToday")]
        Phone5AttemptsToday = 68,

        [JsonPropertyName("phone5CellConsent")]
        Phone5CellConsent = 69,

        [JsonPropertyName("phone5Block")]
        Phone5Block = 70,

        [JsonPropertyName("phone5BlockDaily")]
        Phone5BlockDaily = 71,

        [JsonPropertyName("phone5SmsConsent")]
        Phone5SmsConsent = 72,

        [JsonPropertyName("phone6")]
        Phone6 = 73,

        [JsonPropertyName("phone6AttemptsTotal")]
        Phone6AttemptsTotal = 74,

        [JsonPropertyName("phone6AttemptsToday")]
        Phone6AttemptsToday = 75,

        [JsonPropertyName("phone6CellConsent")]
        Phone6CellConsent = 76,

        [JsonPropertyName("phone6Block")]
        Phone6Block = 77,

        [JsonPropertyName("phone6BlockDaily")]
        Phone6BlockDaily = 78,

        [JsonPropertyName("phone6SmsConsent")]
        Phone6SmsConsent = 79,

        [JsonPropertyName("phone7")]
        Phone7 = 80,

        [JsonPropertyName("phone7AttemptsTotal")]
        Phone7AttemptsTotal = 81,

        [JsonPropertyName("phone7AttemptsToday")]
        Phone7AttemptsToday = 82,

        [JsonPropertyName("phone7CellConsent")]
        Phone7CellConsent = 83,

        [JsonPropertyName("phone7Block")]
        Phone7Block = 84,

        [JsonPropertyName("phone7BlockDaily")]
        Phone7BlockDaily = 85,

        [JsonPropertyName("phone7SmsConsent")]
        Phone7SmsConsent = 86,

        [JsonPropertyName("phone8")]
        Phone8 = 87,

        [JsonPropertyName("phone8AttemptsTotal")]
        Phone8AttemptsTotal = 88,

        [JsonPropertyName("phone8AttemptsToday")]
        Phone8AttemptsToday = 89,

        [JsonPropertyName("phone8CellConsent")]
        Phone8CellConsent = 90,

        [JsonPropertyName("phone8Block")]
        Phone8Block = 91,

        [JsonPropertyName("phone8BlockDaily")]
        Phone8BlockDaily = 92,

        [JsonPropertyName("phone8SmsConsent")]
        Phone8SmsConsent = 93,

        [JsonPropertyName("phone9")]
        Phone9 = 94,

        [JsonPropertyName("phone9AttemptsTotal")]
        Phone9AttemptsTotal = 95,

        [JsonPropertyName("phone9AttemptsToday")]
        Phone9AttemptsToday = 96,

        [JsonPropertyName("phone9CellConsent")]
        Phone9CellConsent = 97,

        [JsonPropertyName("phone9Block")]
        Phone9Block = 98,

        [JsonPropertyName("phone9BlockDaily")]
        Phone9BlockDaily = 99,

        [JsonPropertyName("phone9SmsConsent")]
        Phone9SmsConsent = 100,

        [JsonPropertyName("phone10")]
        Phone10 = 101,

        [JsonPropertyName("phone10AttemptsTotal")]
        Phone10AttemptsTotal = 102,

        [JsonPropertyName("phone10AttemptsToday")]
        Phone10AttemptsToday = 103,

        [JsonPropertyName("phone10CellConsent")]
        Phone10CellConsent = 104,

        [JsonPropertyName("phone10Block")]
        Phone10Block = 105,

        [JsonPropertyName("phone10BlockDaily")]
        Phone10BlockDaily = 106,

        [JsonPropertyName("phone10SmsConsent")]
        Phone10SmsConsent = 107,

        [JsonPropertyName("zipCode")]
        ZipCode = 108,

        [JsonPropertyName("primaryEmailConsent")]
        PrimaryEmailConsent = 109,

        [JsonPropertyName("salutation")]
        Salutation = 110,

        [JsonPropertyName("primarySMSConsent")]
        PrimarySMSConsent = 111,

        [JsonPropertyName("ssn")]
        SSN = 112,

        [JsonPropertyName("state")]
        State = 113,

        [JsonPropertyName("title")]
        Title = 114,

        [JsonPropertyName("COL1")]
        COL1 = 115,

        [JsonPropertyName("COL2")]
        COL2 = 116,

        [JsonPropertyName("COL3")]
        COL3 = 117,

        [JsonPropertyName("COL4")]
        COL4 = 118,

        [JsonPropertyName("COL5")]
        COL5 = 119,

        [JsonPropertyName("COL6")]
        COL6 = 120,

        [JsonPropertyName("COL7")]
        COL7 = 121,

        [JsonPropertyName("COL8")]
        COL8 = 122,

        [JsonPropertyName("COL9")]
        COL9 = 123,

        [JsonPropertyName("COL10")]
        COL10 = 124,

        [JsonPropertyName("COL11")]
        COL11 = 125,

        [JsonPropertyName("COL12")]
        COL12 = 126,

        [JsonPropertyName("COL13")]
        COL13 = 127,

        [JsonPropertyName("COL14")]
        COL14 = 128,

        [JsonPropertyName("COL15")]
        COL15 = 129,

        [JsonPropertyName("COL16")]
        COL16 = 130,

        [JsonPropertyName("COL17")]
        COL17 = 131,

        [JsonPropertyName("COL18")]
        COL18 = 132,

        [JsonPropertyName("COL19")]
        COL19 = 133,

        [JsonPropertyName("COL20")]
        COL20 = 134,

        [JsonPropertyName("COL21")]
        COL21 = 135,

        [JsonPropertyName("COL22")]
        COL22 = 136,

        [JsonPropertyName("COL23")]
        COL23 = 137,

        [JsonPropertyName("COL24")]
        COL24 = 138,

        [JsonPropertyName("COL25")]
        COL25 = 139,

        [JsonPropertyName("COL26")]
        COL26 = 140,

        [JsonPropertyName("COL27")]
        COL27 = 141,

        [JsonPropertyName("COL28")]
        COL28 = 142,

        [JsonPropertyName("COL29")]
        COL29 = 143,

        [JsonPropertyName("COL30")]
        COL30 = 144,

        [JsonPropertyName("COL31")]
        COL31 = 145,

        [JsonPropertyName("COL32")]
        COL32 = 146,

        [JsonPropertyName("COL33")]
        COL33 = 147,

        [JsonPropertyName("COL34")]
        COL34 = 148,

        [JsonPropertyName("COL35")]
        COL35 = 149,

        [JsonPropertyName("COL36")]
        COL36 = 150,

        [JsonPropertyName("COL37")]
        COL37 = 151,

        [JsonPropertyName("COL38")]
        COL38 = 152,

        [JsonPropertyName("COL39")]
        COL39 = 153,

        [JsonPropertyName("COL40")]
        COL40 = 154,

        [JsonPropertyName("COL41")]
        COL41 = 155,

        [JsonPropertyName("COL42")]
        COL42 = 156,

        [JsonPropertyName("COL43")]
        COL43 = 157,

        [JsonPropertyName("COL44")]
        COL44 = 158,

        [JsonPropertyName("COL45")]
        COL45 = 159,

        [JsonPropertyName("COL46")]
        COL46 = 160,

        [JsonPropertyName("COL47")]
        COL47 = 161,

        [JsonPropertyName("COL48")]
        COL48 = 162,

        [JsonPropertyName("COL49")]
        COL49 = 163,

        [JsonPropertyName("COL50")]
        COL50 = 164,

        [JsonPropertyName("COL51")]
        COL51 = 165,

        [JsonPropertyName("COL52")]
        COL52 = 166,

        [JsonPropertyName("COL53")]
        COL53 = 167,

        [JsonPropertyName("COL54")]
        COL54 = 168,

        [JsonPropertyName("COL55")]
        COL55 = 169,

        [JsonPropertyName("COL56")]
        COL56 = 170,

        [JsonPropertyName("COL57")]
        COL57 = 171,

        [JsonPropertyName("COL58")]
        COL58 = 172,

        [JsonPropertyName("COL59")]
        COL59 = 173,

        [JsonPropertyName("COL60")]
        COL60 = 174,

        [JsonPropertyName("COL61")]
        COL61 = 175,

        [JsonPropertyName("COL62")]
        COL62 = 176,

        [JsonPropertyName("COL63")]
        COL63 = 177,

        [JsonPropertyName("COL64")]
        COL64 = 178,

        [JsonPropertyName("COL65")]
        COL65 = 179,
        
        [JsonPropertyName("COL66")]
        COL66 = 180,
        
        [JsonPropertyName("COL67")]
        COL67 = 181,
        
        [JsonPropertyName("COL68")]
        COL68 = 182,
        
        [JsonPropertyName("COL69")]
        COL69 = 183,
        
        [JsonPropertyName("COL70")]
        COL70 = 184,
        
        [JsonPropertyName("COL71")]
        COL71 = 185,
        
        [JsonPropertyName("COL72")]
        COL72 = 186,
        
        [JsonPropertyName("COL73")]
        COL73 = 187,
        
        [JsonPropertyName("COL74")]
        COL74 = 188,
        
        [JsonPropertyName("COL75")]
        COL75 = 189,
        
        [JsonPropertyName("COL76")]
        COL76 = 190,
        
        [JsonPropertyName("COL77")]
        COL77 = 191,
        
        [JsonPropertyName("COL78")]
        COL78 = 192,
        
        [JsonPropertyName("COL79")]
        COL79 = 193,
        
        [JsonPropertyName("COL80")]
        COL80 = 194,
        
        [JsonPropertyName("COL81")]
        COL81 = 195,
        
        [JsonPropertyName("COL82")]
        COL82 = 196,
        
        [JsonPropertyName("COL83")]
        COL83 = 197,
        
        [JsonPropertyName("COL84")]
        COL84 = 198,
        
        [JsonPropertyName("COL85")]
        COL85 = 199,
        
        [JsonPropertyName("COL86")]
        COL86 = 200,
        
        [JsonPropertyName("COL87")]
        COL87 = 201,
        
        [JsonPropertyName("COL88")]
        COL88 = 202,
        
        [JsonPropertyName("COL89")]
        COL89 = 203,
        
        [JsonPropertyName("COL90")]
        COL90 = 204,
        
        [JsonPropertyName("COL91")]
        COL91 = 205,
        
        [JsonPropertyName("COL92")]
        COL92 = 206,
        
        [JsonPropertyName("COL93")]
        COL93 = 207,
        
        [JsonPropertyName("COL94")]
        COL94 = 208,
        
        [JsonPropertyName("COL95")]
        COL95 = 209,
        
        [JsonPropertyName("COL96")]
        COL96 = 210,
        
        [JsonPropertyName("COL97")]
        COL97 = 211,
        
        [JsonPropertyName("COL98")]
        COL98 = 212,
        
        [JsonPropertyName("COL99")]
        COL99 = 213,
        
        [JsonPropertyName("COL100")]
        COL100 = 214

    }
}
