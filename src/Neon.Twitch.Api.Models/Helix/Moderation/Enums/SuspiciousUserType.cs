using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SuspiciousUserType
{
    [JsonStringEnumMemberName("MANUALLY_ADDED")]
    ManuallyAdded,
    [JsonStringEnumMemberName("DETECTED_BAN_EVADER")]
    DetectedBanEvader,
    [JsonStringEnumMemberName("DETECTED_SUS_CHATTER")]
    DetectedSusChatter,
    [JsonStringEnumMemberName("BANNED_IN_SHARED_CHANNEL")]
    BannedInSharedChannel
}