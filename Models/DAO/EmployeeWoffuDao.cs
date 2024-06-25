using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace SercomApp.Models.DAO
{
    public class EmployeeWoffuDao
    {
        public class Data
        {
            [JsonProperty("$id")]
            // [JsonConverter(typeof(ParseStringConverter))]
            public long Id { get; set; }

            [JsonProperty("UserId")] public long UserId { get; set; }

            [JsonProperty("UserKey")] public string UserKey { get; set; }

            [JsonProperty("FirstName")] public string FirstName { get; set; }

            [JsonProperty("LastName")] public string LastName { get; set; }

            [JsonProperty("Acronym")] public string Acronym { get; set; }

            [JsonProperty("Email")] public string Email { get; set; }

            [JsonProperty("CompanyId")] public long CompanyId { get; set; }

            [JsonProperty("EmployeeStartDate")] public DateTimeOffset EmployeeStartDate { get; set; }

            [JsonProperty("EmployeeEndDate")] public object EmployeeEndDate { get; set; }

            [JsonProperty("Birthday")] public DateTimeOffset? Birthday { get; set; }

            [JsonProperty("ImageURL")] public Uri ImageUrl { get; set; }

            [JsonProperty("DepartmentId")] public long? DepartmentId { get; set; }

            [JsonProperty("JobTitleId")] public long JobTitleId { get; set; }

            [JsonProperty("ResponsibleUserId")] public long ResponsibleUserId { get; set; }

            [JsonProperty("AuthorizingUserId")] public long? AuthorizingUserId { get; set; }

            [JsonProperty("AllocatedDays")] public double AllocatedDays { get; set; }

            [JsonProperty("UsedDays")] public long UsedDays { get; set; }

            [JsonProperty("AvailableDays")] public double AvailableDays { get; set; }

            [JsonProperty("AccumulatedDays")] public double AccumulatedDays { get; set; }

            [JsonProperty("LanguageId")] public long LanguageId { get; set; }

            [JsonProperty("Weekends")] public object Weekends { get; set; }

            [JsonProperty("CalendarId")] public long CalendarId { get; set; }

            [JsonProperty("AgreementId")] public long AgreementId { get; set; }

            [JsonProperty("OfficeId")] public long OfficeId { get; set; }

            [JsonProperty("ScheduleId")] public long ScheduleId { get; set; }

            [JsonProperty("InheredScheduleId")] public long InheredScheduleId { get; set; }

            [JsonProperty("IsAdmin")] public bool IsAdmin { get; set; }

            [JsonProperty("IsResponsible")] public bool IsResponsible { get; set; }

            [JsonProperty("Active")] public bool Active { get; set; }

            [JsonProperty("NIN")] public string Nin { get; set; }

            [JsonProperty("SSN")] public string Ssn { get; set; }

            [JsonProperty("RoleId")] public long RoleId { get; set; }

            [JsonProperty("Deleted")] public bool Deleted { get; set; }

            [JsonProperty("SignDeviceTypes")] public long SignDeviceTypes { get; set; }

            [JsonProperty("ContractId")] public long ContractId { get; set; }
        }

//         public partial class Data
//         {
//             public static List<Data> FromJson(string json) =>
//                 JsonConvert.DeserializeObject<List<Data>>(json, QuickType.Converter.Settings);
//         }
//
//         public static class Serialize
//         {
//             public static string ToJson(this List<Data> self) =>
//                 JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
//         }
//
//         internal static class Converter
//         {
//             public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
//             {
//                 MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
//                 DateParseHandling = DateParseHandling.None,
//                 Converters =
//                 {
//                     new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
//                 },
//             };
//         }
//
//         internal class ParseStringConverter : JsonConverter
//         {
//             public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);
//
//             public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//             {
//                 if (reader.TokenType == JsonToken.Null) return null;
//                 var value = serializer.Deserialize<string>(reader);
//                 long l;
//                 if (Int64.TryParse(value, out l))
//                 {
//                     return l;
//                 }
//
//                 throw new Exception("Cannot unmarshal type long");
//             }
//
//             public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//             {
//                 if (untypedValue == null)
//                 {
//                     serializer.Serialize(writer, null);
//                     return;
//                 }
//
//                 var value = (long)untypedValue;
//                 serializer.Serialize(writer, value.ToString());
//                 return;
//             }
//
//             public static readonly ParseStringConverter Singleton = new ParseStringConverter();
//         }
//     }
//
//     public class JsonPropertyAttribute : Attribute
//     {
//         public JsonPropertyAttribute(string id)
//         {
//             throw new NotImplementedException();
//         }
     }
}