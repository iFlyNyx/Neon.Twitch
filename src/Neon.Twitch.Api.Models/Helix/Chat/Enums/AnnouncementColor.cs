using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum AnnouncementColor
{
    [JsonStringEnumMemberName("blue")]
    Blue,
    [JsonStringEnumMemberName("green")]
    Green,
    [JsonStringEnumMemberName("orange")]
    Orange,
    [JsonStringEnumMemberName("purple")]
    Purple,
    [JsonStringEnumMemberName("primary")]
    Primary
}