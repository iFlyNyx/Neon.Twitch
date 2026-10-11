using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum EmoteTheme
{
    [JsonStringEnumMemberName("light")]
    Light,
    [JsonStringEnumMemberName("dark")]
    Dark
}