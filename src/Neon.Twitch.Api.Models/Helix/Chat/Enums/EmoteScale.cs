using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum EmoteScale
{
    [JsonStringEnumMemberName("1.0")]
    Scale1,
    [JsonStringEnumMemberName("2.0")]
    Scale2,
    [JsonStringEnumMemberName("3.0")]
    Scale3
}