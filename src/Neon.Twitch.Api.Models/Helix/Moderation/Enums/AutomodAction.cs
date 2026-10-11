using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum AutomodAction
{
    [JsonStringEnumMemberName("ALLOW")]
    Allow,
    [JsonStringEnumMemberName("DENY")]
    Deny
}