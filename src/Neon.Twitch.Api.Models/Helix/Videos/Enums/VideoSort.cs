using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Videos.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum VideoSort
{
    [JsonStringEnumMemberName("time")]
    Time,
    [JsonStringEnumMemberName("trending")]
    Trending,
    [JsonStringEnumMemberName("views")]
    Views
}