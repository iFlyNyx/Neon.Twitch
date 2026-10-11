using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum ExtensionConfigurationSegment
{
    [JsonStringEnumMemberName("broadcaster")]
    Broadcaster,
    [JsonStringEnumMemberName("developer")]
    Developer,
    [JsonStringEnumMemberName("global")]
    Global
}