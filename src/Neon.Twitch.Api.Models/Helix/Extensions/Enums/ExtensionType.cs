using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum ExtensionType
{
    [JsonStringEnumMemberName("bits")]
    Bits
}