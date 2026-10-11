using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum FragmentType
{
    [JsonStringEnumMemberName("text")]
    Text,
    [JsonStringEnumMemberName("emote")]
    Emote,
    [JsonStringEnumMemberName("cheermote")]
    Cheermote,
    [JsonStringEnumMemberName("mention")]
    Mention
}