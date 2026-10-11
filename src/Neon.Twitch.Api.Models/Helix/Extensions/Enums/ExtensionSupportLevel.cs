using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum ExtensionSupportLevel
{
    [JsonStringEnumMemberName("none")]
    None,
    [JsonStringEnumMemberName("optional")]
    Optional
}