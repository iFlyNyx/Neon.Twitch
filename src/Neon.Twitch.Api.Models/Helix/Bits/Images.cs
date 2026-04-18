using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Bits;

public class Images
{
    [JsonPropertyName("dark")]
    public ImageCollection? Dark { get; init; }
    [JsonPropertyName("light")]
    public ImageCollection? Light { get; init; }
}