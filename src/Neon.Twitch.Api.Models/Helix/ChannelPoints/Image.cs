using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.ChannelPoints;

public class Image
{
    /// <summary>
    /// <para>The URL to a small version of the image.</para>
    /// </summary>
    [JsonPropertyName("url_1x")]
    public string? Url1X { get; init; }
    /// <summary>
    /// <para>The URL to a medium version of the image.</para>
    /// </summary>
    [JsonPropertyName("url_2x")]
    public string? Url2X { get; init; }
    /// <summary>
    /// <para>The URL to a large version of the image.</para>
    /// </summary>
    [JsonPropertyName("url_4x")]
    public string? Url4X { get; init; }
}