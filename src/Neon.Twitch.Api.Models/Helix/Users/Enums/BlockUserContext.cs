using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BlockUserContext
{
    [JsonStringEnumMemberName("chat")]
    Chat,
    [JsonStringEnumMemberName("whisper")]
    Whisper
}