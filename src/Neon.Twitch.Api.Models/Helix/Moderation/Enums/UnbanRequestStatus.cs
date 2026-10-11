using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UnbanRequestStatus
{
    [JsonStringEnumMemberName("pending")]
    Pending,
    [JsonStringEnumMemberName("approved")]
    Approved,
    [JsonStringEnumMemberName("denied")]
    Denied, 
    [JsonStringEnumMemberName("acknowledged")]
    Acknowledged,
    [JsonStringEnumMemberName("canceled")]
    Canceled
}