using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BlockUserReason
{
    [JsonStringEnumMemberName("harassment")]
    Harassment,
    [JsonStringEnumMemberName("spam")]
    Spam,
    [JsonStringEnumMemberName("other")]
    Other
}