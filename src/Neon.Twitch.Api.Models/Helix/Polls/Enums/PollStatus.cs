using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Polls.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PollStatus
{
    [JsonStringEnumMemberName("ACTIVE")]
    Active,
    [JsonStringEnumMemberName("COMPLETED")]
    Completed,
    [JsonStringEnumMemberName("TERMINATED")]
    Terminated,
    [JsonStringEnumMemberName("ARCHIVED")]
    Archived,
    [JsonStringEnumMemberName("MODERATED")]
    Moderated,
    [JsonStringEnumMemberName("INVALID")]
    Invalid
}