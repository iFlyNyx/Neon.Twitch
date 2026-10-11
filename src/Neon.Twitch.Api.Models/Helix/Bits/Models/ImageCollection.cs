using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Bits.Models;

internal class ImageCollection
{
    [JsonPropertyName("animated")]
    public Dictionary<string, string>? Animated { get; init; }
    [JsonPropertyName("static")]
    public Dictionary<string, string>? Static { get; init; }
}