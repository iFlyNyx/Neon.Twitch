using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Bits.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum BitsLeaderboardPeriod
{
    [JsonStringEnumMemberName("day")]
    Day,
    [JsonStringEnumMemberName("week")]
    Week,
    [JsonStringEnumMemberName("month")]
    Month,
    [JsonStringEnumMemberName("year")]
    Year,
    [JsonStringEnumMemberName("all")]
    All
}