using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Polls.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum EndPollStatus
{
    [JsonStringEnumMemberName("TERMINATED")]
    Terminated,
    [JsonStringEnumMemberName("ARCHIVED")]
    Archived
}