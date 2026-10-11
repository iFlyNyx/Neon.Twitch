using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UnbanRequestPatchStatus
{
    [JsonStringEnumMemberName("APPROVED")]
    Approved,
    [JsonStringEnumMemberName("DENIED")]
    Denied
}