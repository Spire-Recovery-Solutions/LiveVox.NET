using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Contact.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SearchContactsSortField
    {
        [JsonPropertyName("LVACCOUNT_ID")]
        LVACCOUNT_ID = 0,

        [JsonPropertyName("CLIENT_ID")]
        CLIENT_ID = 1,

        [JsonPropertyName("ACCOUNT")]
        ACCOUNT = 2,

        [JsonPropertyName("B_ACTIVE")]
        B_ACTIVE = 3,

        [JsonPropertyName("ACCOUNT_TO_SPEAK")]
        ACCOUNT_TO_SPEAK = 4,

        [JsonPropertyName("FIRST_NAME")]
        FIRST_NAME = 5,

        [JsonPropertyName("LAST_NAME")]
        LAST_NAME = 6,

        [JsonPropertyName("DOB")]
        DOB = 7,

        [JsonPropertyName("EMAIL_ADDRESS")]
        EMAIL_ADDRESS = 8,

        [JsonPropertyName("SSN")]
        SSN = 9,

        [JsonPropertyName("PHONE1")]
        PHONE1 = 10,

        [JsonPropertyName("PHONE2")]
        PHONE2 = 11,

        [JsonPropertyName("PHONE3")]
        PHONE3 = 12,

        [JsonPropertyName("PHONE4")]
        PHONE4 = 13,

        [JsonPropertyName("PHONE5")]
        PHONE5 = 14,

        [JsonPropertyName("PHONE6")]
        PHONE6 = 15,

        [JsonPropertyName("PHONE7")]
        PHONE7 = 16,

        [JsonPropertyName("PHONE8")]
        PHONE8 = 17,

        [JsonPropertyName("PHONE9")]
        PHONE9 = 18,

        [JsonPropertyName("PHONE10")]
        PHONE10 = 19,

        [JsonPropertyName("ADDRESS1")]
        ADDRESS1 = 20,

        [JsonPropertyName("ADDRESS2")]
        ADDRESS2 = 21,

        [JsonPropertyName("CITY")]
        CITY = 22,

        [JsonPropertyName("STATE")]
        STATE = 23,

        [JsonPropertyName("POSTALCODE")]
        POSTALCODE = 24,

        [JsonPropertyName("COUNTRY_ID")]
        COUNTRY_ID = 25,

        [JsonPropertyName("GUARANTOR_FIRSTNAME")]
        GUARANTOR_FIRSTNAME = 26,

        [JsonPropertyName("GUARANTOR_LASTNAME")]
        GUARANTOR_LASTNAME = 27,

        [JsonPropertyName("PAYMENTBALANCE")]
        PAYMENTBALANCE = 28,

        [JsonPropertyName("AMOUNT_TO_SPEAK")]
        AMOUNT_TO_SPEAK = 29,

        [JsonPropertyName("ACCOUNT_DUE_DATE")]
        ACCOUNT_DUE_DATE = 30,

        [JsonPropertyName("CALLATTEMPTSTODAY")]
        CALLATTEMPTSTODAY = 31,

        [JsonPropertyName("CALLATTEMPTSLIFETIME")]
        CALLATTEMPTSLIFETIME = 32,

        [JsonPropertyName("CREATEDATE")]
        CREATEDATE = 33,

        [JsonPropertyName("CREATEUSER")]
        CREATEUSER = 34,

        [JsonPropertyName("MODIFYDATE")]
        MODIFYDATE = 35,

        [JsonPropertyName("MODIFYUSER")]
        MODIFYUSER = 36,

        [JsonPropertyName("INITIAL_LOAD_DATE")]
        INITIAL_LOAD_DATE = 37,

        [JsonPropertyName("INITIAL_LOAD_CAMPAIGNID")]
        INITIAL_LOAD_CAMPAIGNID = 38,

        [JsonPropertyName("LAST_LOAD_DATE")]
        LAST_LOAD_DATE = 39,

        [JsonPropertyName("LAST_LOAD_CAMPAIGNID")]
        LAST_LOAD_CAMPAIGNID = 40,

        [JsonPropertyName("DO_NOT_DIAL")]
        DO_NOT_DIAL = 41,

        [JsonPropertyName("DO_NOT_DIAL_DAILY")]
        DO_NOT_DIAL_DAILY = 42,

        [JsonPropertyName("GROUP_ID")]
        GROUP_ID = 43,

        [JsonPropertyName("ORIGINAL_ACCOUNT_NUMBER")]
        ORIGINAL_ACCOUNT_NUMBER = 44,

        [JsonPropertyName("PHONE1_ATTEMPTS_TODAY")]
        PHONE1_ATTEMPTS_TODAY = 45,

        [JsonPropertyName("PHONE1_ATTEMPTS_LIFETIME")]
        PHONE1_ATTEMPTS_LIFETIME = 46,

        [JsonPropertyName("PHONE1_DND")]
        PHONE1_DND = 47,

        [JsonPropertyName("PHONE1_DND_DAILY")]
        PHONE1_DND_DAILY = 48,

        [JsonPropertyName("PHONE2_ATTEMPTS_TODAY")]
        PHONE2_ATTEMPTS_TODAY = 49,

        [JsonPropertyName("PHONE2_ATTEMPTS_LIFETIME")]
        PHONE2_ATTEMPTS_LIFETIME = 50,

        [JsonPropertyName("PHONE2_DND")]
        PHONE2_DND = 51,

        [JsonPropertyName("PHONE2_DND_DAILY")]
        PHONE2_DND_DAILY = 52,

        [JsonPropertyName("PHONE3_ATTEMPTS_TODAY")]
        PHONE3_ATTEMPTS_TODAY = 53,

        [JsonPropertyName("PHONE3_ATTEMPTS_LIFETIME")]
        PHONE3_ATTEMPTS_LIFETIME = 54,

        [JsonPropertyName("PHONE3_DND")]
        PHONE3_DND = 55,

        [JsonPropertyName("PHONE3_DND_DAILY")]
        PHONE3_DND_DAILY = 56,

        [JsonPropertyName("PHONE4_ATTEMPTS_TODAY")]
        PHONE4_ATTEMPTS_TODAY = 57,

        [JsonPropertyName("PHONE4_ATTEMPTS_LIFETIME")]
        PHONE4_ATTEMPTS_LIFETIME = 58,

        [JsonPropertyName("PHONE4_DND")]
        PHONE4_DND = 59,

        [JsonPropertyName("PHONE4_DND_DAILY")]
        PHONE4_DND_DAILY = 60,

        [JsonPropertyName("PHONE5_ATTEMPTS_TODAY")]
        PHONE5_ATTEMPTS_TODAY = 61,

        [JsonPropertyName("PHONE5_ATTEMPTS_LIFETIME")]
        PHONE5_ATTEMPTS_LIFETIME = 62,

        [JsonPropertyName("PHONE5_DND")]
        PHONE5_DND = 63,

        [JsonPropertyName("PHONE5_DND_DAILY")]
        PHONE5_DND_DAILY = 64,

        [JsonPropertyName("PHONE6_ATTEMPTS_TODAY")]
        PHONE6_ATTEMPTS_TODAY = 65,

        [JsonPropertyName("PHONE6_ATTEMPTS_LIFETIME")]
        PHONE6_ATTEMPTS_LIFETIME = 66,

        [JsonPropertyName("PHONE6_DND")]
        PHONE6_DND = 67,

        [JsonPropertyName("PHONE6_DND_DAILY")]
        PHONE6_DND_DAILY = 68,

        [JsonPropertyName("PHONE7_ATTEMPTS_TODAY")]
        PHONE7_ATTEMPTS_TODAY = 69,

        [JsonPropertyName("PHONE7_ATTEMPTS_LIFETIME")]
        PHONE7_ATTEMPTS_LIFETIME = 70,

        [JsonPropertyName("PHONE7_DND")]
        PHONE7_DND = 71,

        [JsonPropertyName("PHONE7_DND_DAILY")]
        PHONE7_DND_DAILY = 72,

        [JsonPropertyName("PHONE8_ATTEMPTS_TODAY")]
        PHONE8_ATTEMPTS_TODAY = 73,

        [JsonPropertyName("PHONE8_ATTEMPTS_LIFETIME")]
        PHONE8_ATTEMPTS_LIFETIME = 74,

        [JsonPropertyName("PHONE8_DND")]
        PHONE8_DND = 75,

        [JsonPropertyName("PHONE8_DND_DAILY")]
        PHONE8_DND_DAILY = 76,

        [JsonPropertyName("PHONE9_ATTEMPTS_TODAY")]
        PHONE9_ATTEMPTS_TODAY = 77,

        [JsonPropertyName("PHONE9_ATTEMPTS_LIFETIME")]
        PHONE9_ATTEMPTS_LIFETIME = 78,

        [JsonPropertyName("PHONE9_DND")]
        PHONE9_DND = 79,

        [JsonPropertyName("PHONE9_DND_DAILY")]
        PHONE9_DND_DAILY = 80,

        [JsonPropertyName("PHONE10_ATTEMPTS_TODAY")]
        PHONE10_ATTEMPTS_TODAY = 81,

        [JsonPropertyName("PHONE10_ATTEMPTS_LIFETIME")]
        PHONE10_ATTEMPTS_LIFETIME = 82,

        [JsonPropertyName("PHONE10_DND")]
        PHONE10_DND = 83,

        [JsonPropertyName("PHONE10_DND_DAILY")]
        PHONE10_DND_DAILY = 84,

        [JsonPropertyName("SMS")]
        SMS = 85,

        [JsonPropertyName("EMAIL")]
        EMAIL = 86,

        [JsonPropertyName("PHONE1_SMS_CONSENT")]
        PHONE1_SMS_CONSENT = 87,

        [JsonPropertyName("PHONE1_CELL_CONSENT")]
        PHONE1_CELL_CONSENT = 88,

        [JsonPropertyName("PHONE2_SMS_CONSENT")]
        PHONE2_SMS_CONSENT = 89,

        [JsonPropertyName("PHONE2_CELL_CONSENT")]
        PHONE2_CELL_CONSENT = 90,

        [JsonPropertyName("PHONE3_SMS_CONSENT")]
        PHONE3_SMS_CONSENT = 91,

        [JsonPropertyName("PHONE3_CELL_CONSENT")]
        PHONE3_CELL_CONSENT = 92,

        [JsonPropertyName("PHONE4_SMS_CONSENT")]
        PHONE4_SMS_CONSENT = 93,

        [JsonPropertyName("PHONE4_CELL_CONSENT")]
        PHONE4_CELL_CONSENT = 94,

        [JsonPropertyName("PHONE5_SMS_CONSENT")]
        PHONE5_SMS_CONSENT = 95,

        [JsonPropertyName("PHONE5_CELL_CONSENT")]
        PHONE5_CELL_CONSENT = 96,

        [JsonPropertyName("PHONE6_SMS_CONSENT")]
        PHONE6_SMS_CONSENT = 97,

        [JsonPropertyName("PHONE6_CELL_CONSENT")]
        PHONE6_CELL_CONSENT = 98,

        [JsonPropertyName("PHONE7_SMS_CONSENT")]
        PHONE7_SMS_CONSENT = 99,

        [JsonPropertyName("PHONE7_CELL_CONSENT")]
        PHONE7_CELL_CONSENT = 100,

        [JsonPropertyName("PHONE8_SMS_CONSENT")]
        PHONE8_SMS_CONSENT = 101,

        [JsonPropertyName("PHONE8_CELL_CONSENT")]
        PHONE8_CELL_CONSENT = 102,

        [JsonPropertyName("PHONE9_SMS_CONSENT")]
        PHONE9_SMS_CONSENT = 103,

        [JsonPropertyName("PHONE9_CELL_CONSENT")]
        PHONE9_CELL_CONSENT = 104,

        [JsonPropertyName("PHONE10_SMS_CONSENT")]
        PHONE10_SMS_CONSENT = 105,

        [JsonPropertyName("PHONE10_CELL_CONSENT")]
        PHONE10_CELL_CONSENT = 106,

        [JsonPropertyName("PRIMARY_EMAIL_CONSENT")]
        PRIMARY_EMAIL_CONSENT = 107,

        [JsonPropertyName("COL1")]
        COL1 = 108,

        [JsonPropertyName("COL2")]
        COL2 = 109,

        [JsonPropertyName("COL3")]
        COL3 = 110,

        [JsonPropertyName("COL4")]
        COL4 = 111,

        [JsonPropertyName("COL5")]
        COL5 = 112,

        [JsonPropertyName("COL6")]
        COL6 = 113,

        [JsonPropertyName("COL7")]
        COL7 = 114,

        [JsonPropertyName("COL8")]
        COL8 = 115,

        [JsonPropertyName("COL9")]
        COL9 = 116,

        [JsonPropertyName("COL10")]
        COL10 = 117,

        [JsonPropertyName("COL11")]
        COL11 = 118,

        [JsonPropertyName("COL12")]
        COL12 = 119,

        [JsonPropertyName("COL13")]
        COL13 = 120,

        [JsonPropertyName("COL14")]
        COL14 = 121,

        [JsonPropertyName("COL15")]
        COL15 = 122,

        [JsonPropertyName("COL16")]
        COL16 = 123,

        [JsonPropertyName("COL17")]
        COL17 = 124,

        [JsonPropertyName("COL18")]
        COL18 = 125,

        [JsonPropertyName("COL19")]
        COL19 = 126,

        [JsonPropertyName("COL20")]
        COL20 = 127,

        [JsonPropertyName("COL21")]
        COL21 = 128,

        [JsonPropertyName("COL22")]
        COL22 = 129,

        [JsonPropertyName("COL23")]
        COL23 = 130,

        [JsonPropertyName("COL24")]
        COL24 = 131,

        [JsonPropertyName("COL25")]
        COL25 = 132,

        [JsonPropertyName("COL26")]
        COL26 = 133,

        [JsonPropertyName("COL27")]
        COL27 = 134,

        [JsonPropertyName("COL28")]
        COL28 = 135,

        [JsonPropertyName("COL29")]
        COL29 = 136,

        [JsonPropertyName("COL30")]
        COL30 = 137,

        [JsonPropertyName("COL31")]
        COL31 = 138,

        [JsonPropertyName("COL32")]
        COL32 = 139,

        [JsonPropertyName("COL33")]
        COL33 = 140,

        [JsonPropertyName("COL34")]
        COL34 = 141,

        [JsonPropertyName("COL35")]
        COL35 = 142,

        [JsonPropertyName("COL36")]
        COL36 = 143,

        [JsonPropertyName("COL37")]
        COL37 = 144,

        [JsonPropertyName("COL38")]
        COL38 = 145,

        [JsonPropertyName("COL39")]
        COL39 = 146,

        [JsonPropertyName("COL40")]
        COL40 = 147,

        [JsonPropertyName("COL41")]
        COL41 = 148,

        [JsonPropertyName("COL42")]
        COL42 = 149,

        [JsonPropertyName("COL43")]
        COL43 = 150,

        [JsonPropertyName("COL44")]
        COL44 = 151,

        [JsonPropertyName("COL45")]
        COL45 = 152,

        [JsonPropertyName("COL46")]
        COL46 = 153,

        [JsonPropertyName("COL47")]
        COL47 = 154,

        [JsonPropertyName("COL48")]
        COL48 = 155,

        [JsonPropertyName("COL49")]
        COL49 = 156,

        [JsonPropertyName("COL50")]
        COL50 = 157,

        [JsonPropertyName("COL51")]
        COL51 = 158,

        [JsonPropertyName("COL52")]
        COL52 = 159,

        [JsonPropertyName("COL53")]
        COL53 = 160,

        [JsonPropertyName("COL54")]
        COL54 = 161,

        [JsonPropertyName("COL55")]
        COL55 = 162,

        [JsonPropertyName("COL56")]
        COL56 = 163,

        [JsonPropertyName("COL57")]
        COL57 = 164,

        [JsonPropertyName("COL58")]
        COL58 = 165,

        [JsonPropertyName("COL59")]
        COL59 = 166,

        [JsonPropertyName("COL60")]
        COL60 = 167,

        [JsonPropertyName("COL61")]
        COL61 = 168,

        [JsonPropertyName("COL62")]
        COL62 = 169,

        [JsonPropertyName("COL63")]
        COL63 = 170,

        [JsonPropertyName("COL64")]
        COL64 = 171,

        [JsonPropertyName("COL65")]
        COL65 = 172,

        [JsonPropertyName("COL66")]
        COL66 = 173,

        [JsonPropertyName("COL67")]
        COL67 = 174,

        [JsonPropertyName("COL68")]
        COL68 = 175,

        [JsonPropertyName("COL69")]
        COL69 = 176,

        [JsonPropertyName("COL70")]
        COL70 = 177,

        [JsonPropertyName("COL71")]
        COL71 = 178,

        [JsonPropertyName("COL72")]
        COL72 = 179,

        [JsonPropertyName("COL73")]
        COL73 = 180,

        [JsonPropertyName("COL74")]
        COL74 = 181,

        [JsonPropertyName("COL75")]
        COL75 = 182,

        [JsonPropertyName("COL76")]
        COL76 = 183,

        [JsonPropertyName("COL77")]
        COL77 = 184,

        [JsonPropertyName("COL78")]
        COL78 = 185,

        [JsonPropertyName("COL79")]
        COL79 = 186,

        [JsonPropertyName("COL80")]
        COL80 = 187,

        [JsonPropertyName("COL81")]
        COL81 = 188,

        [JsonPropertyName("COL82")]
        COL82 = 189,

        [JsonPropertyName("COL83")]
        COL83 = 190,

        [JsonPropertyName("COL84")]
        COL84 = 191,

        [JsonPropertyName("COL85")]
        COL85 = 192,

        [JsonPropertyName("COL86")]
        COL86 = 193,

        [JsonPropertyName("COL87")]
        COL87 = 194,

        [JsonPropertyName("COL88")]
        COL88 = 195,

        [JsonPropertyName("COL89")]
        COL89 = 196,

        [JsonPropertyName("COL90")]
        COL90 = 197,

        [JsonPropertyName("COL91")]
        COL91 = 198,

        [JsonPropertyName("COL92")]
        COL92 = 199,

        [JsonPropertyName("COL93")]
        COL93 = 200,

        [JsonPropertyName("COL94")]
        COL94 = 201,

        [JsonPropertyName("COL95")]
        COL95 = 202,

        [JsonPropertyName("COL96")]
        COL96 = 203,

        [JsonPropertyName("COL97")]
        COL97 = 204,

        [JsonPropertyName("COL98")]
        COL98 = 205,

        [JsonPropertyName("COL99")]
        COL99 = 206,

        [JsonPropertyName("COL100")]
        COL100 = 207

    }
}
