using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum EmoteFormat
{
    [JsonStringEnumMemberName("animated")]
    Animated,
    [JsonStringEnumMemberName("static")]
    Static
}