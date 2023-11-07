using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Contact.Enumerations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SearchConditionContactField
    {
        [JsonPropertyName("account")]
        Account = 0,

        [JsonPropertyName("account_due_date")]
        AccountDueDate = 1,

        [JsonPropertyName("account_due_date_basedon_option")]
        AccountDueDateBasedOnOption = 2,

        [JsonPropertyName("last_load_date_basedon_option")]
        LastLoadDateBasedOnOption = 3,

        [JsonPropertyName("original_account_number")]
        OriginalAccountNumber = 4,

        [JsonPropertyName("city")]
        City = 5,

        [JsonPropertyName("state")]
        State = 6,

        [JsonPropertyName("country")]
        Country = 7,

        [JsonPropertyName("group")]
        Group = 8,

        [JsonPropertyName("do_not_dial")]
        DoNotDial = 9,

        [JsonPropertyName("do_not_dial_daily")]
        DoNotDialDaily = 10,

        [JsonPropertyName("sms")]
        SMS = 11,

        [JsonPropertyName("email")]
        Email = 12,

        [JsonPropertyName("postalcode")]
        PostalCode = 13,

        [JsonPropertyName("name")]
        Name = 14,

        [JsonPropertyName("dob")]
        DOB = 15,

        [JsonPropertyName("phone")]
        Phone = 16,

        [JsonPropertyName("address")]
        Address = 17,

        [JsonPropertyName("guarantor_name")]
        GuarantorName = 18,

        [JsonPropertyName("paymentbalance")]
        PaymentBalance = 19,

        [JsonPropertyName("amount_to_speak")]
        AmountToSpeak = 20,

        [JsonPropertyName("account_dial_yesterday")]
        AccountDialYesterday = 21,

        [JsonPropertyName("account_dial_today")]
        AccountDialToday = 22,

        [JsonPropertyName("phone1_sms_consent")]
        Phone1SMSConsent = 23,

        [JsonPropertyName("phone1_cell_consent")]
        Phone1CellConsent = 24,

        [JsonPropertyName("phone2_sms_consent")]
        Phone2SMSConsent = 25,

        [JsonPropertyName("phone2_cell_consent")]
        Phone2CellConsent = 26,

        [JsonPropertyName("phone3_sms_consent")]
        Phone3SMSConsent = 27,

        [JsonPropertyName("phone3_cell_consent")]
        Phone3CellConsent = 28,

        [JsonPropertyName("phone4_sms_consent")]
        Phone4SMSConsent = 29,

        [JsonPropertyName("phone4_cell_consent")]
        Phone4CellConsent = 30,

        [JsonPropertyName("phone5_sms_consent")]
        Phone5SMSConsent = 31,

        [JsonPropertyName("phone5_cell_consent")]
        Phone5CellConsent = 32,

        [JsonPropertyName("phone6_sms_consent")]
        Phone6SMSConsent = 33,

        [JsonPropertyName("phone6_cell_consent")]
        Phone6CellConsent = 34,

        [JsonPropertyName("phone7_sms_consent")]
        Phone7SMSConsent = 35,

        [JsonPropertyName("phone7_cell_consent")]
        Phone7CellConsent = 36,

        [JsonPropertyName("phone8_sms_consent")]
        Phone8SMSConsent = 37,

        [JsonPropertyName("phone8_cell_consent")]
        Phone8CellConsent = 38,

        [JsonPropertyName("phone9_sms_consent")]
        Phone9SMSConsent = 39,

        [JsonPropertyName("phone9_cell_consent")]
        Phone9CellConsent = 40,

        [JsonPropertyName("phone10_sms_consent")]
        Phone10SMSConsent = 41,

        [JsonPropertyName("phone10_cell_consent")]
        Phone10CellConsent = 42,

        [JsonPropertyName("phone_sms_consent")]
        PhoneSMSConsent = 43,

        [JsonPropertyName("phone_cell_consent")]
        PhoneCellConsent = 44,

        [JsonPropertyName("primary_email_consent")]
        PrimaryEmailConsent = 45,

        [JsonPropertyName("callattemptstoday")]
        CallAttemptsToday = 46,

        [JsonPropertyName("callattemptslifetime")]
        CallAttemptsLifetime = 47,

        [JsonPropertyName("accountForTodaysResult")]
        AccountForTodaysResult = 48,

        [JsonPropertyName("accountsFor30daysResult")]
        AccountsFor30DaysResult = 49,

        [JsonPropertyName("email_address")]
        EmailAddress = 50,

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
