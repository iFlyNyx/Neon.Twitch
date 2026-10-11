using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Analytics.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum AnalyticsReportType
{
    [JsonStringEnumMemberName("OVERVIEW_V2")]
    Overview_V2
}