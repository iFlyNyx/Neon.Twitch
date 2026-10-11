using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Videos.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum VideoPeriod
{
    [JsonStringEnumMemberName("all")]
    All,
    [JsonStringEnumMemberName("day")]
    Day,
    [JsonStringEnumMemberName("month")]
    Month,  
    [JsonStringEnumMemberName("week")]
    Week
}