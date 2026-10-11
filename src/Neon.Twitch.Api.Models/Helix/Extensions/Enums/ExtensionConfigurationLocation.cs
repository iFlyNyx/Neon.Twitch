using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum ExtensionConfigurationLocation
{
    [JsonStringEnumMemberName("hosted")]
    Hosted,
    [JsonStringEnumMemberName("customer")]
    Customer,
    [JsonStringEnumMemberName("none")]
    None
}