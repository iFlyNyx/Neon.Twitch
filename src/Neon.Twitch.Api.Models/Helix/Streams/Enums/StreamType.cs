using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Streams.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum StreamType
{
    [JsonStringEnumMemberName("all")]
    All,
    [JsonStringEnumMemberName("live")]
    Live
}