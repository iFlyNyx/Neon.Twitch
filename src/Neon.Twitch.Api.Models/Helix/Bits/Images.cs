using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Bits;

public class Images
{
    [JsonPropertyName("dark")]
    public ImageCollection? Dark { get; set; }
    [JsonPropertyName("light")]
    public ImageCollection? Light { get; set; }
}