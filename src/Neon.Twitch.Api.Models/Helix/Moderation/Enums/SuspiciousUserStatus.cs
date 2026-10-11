using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SuspiciousUserStatus
{
    [JsonStringEnumMemberName("ACTIVE_MONITORING")]
    ActiveMonitoring,
    [JsonStringEnumMemberName("RESTRICTED")]
    Restricted
}