using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Entitlements.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum EntitlementStatus
{
    [JsonStringEnumMemberName("INVALID_ID")]
    InvalidId,
    [JsonStringEnumMemberName("NOT_FOUND")]
    NotFound,
    [JsonStringEnumMemberName("SUCCESS")]
    Success,
    [JsonStringEnumMemberName("UNAUTHORIZED")]
    Unauthorized,
    [JsonStringEnumMemberName("UPDATE_FAILED")]
    UpdateFailed
}