using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum ExtensionProductType
{
    [JsonStringEnumMemberName("BITS_IN_EXTENSION")]
    BitsInExtension
}