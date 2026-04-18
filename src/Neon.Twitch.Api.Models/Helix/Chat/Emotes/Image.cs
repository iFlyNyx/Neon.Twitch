using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Emotes;

public class Image
{
    /// <summary>
    /// <para>A URL to the small version (28px x 28px) of the emote.</para>
    /// </summary>
    [JsonPropertyName("url_1x")]
    public string? Url1X { get; init; }
    /// <summary>
    /// <para>A URL to the medium version (56px x 56px) of the emote.</para>
    /// </summary>
    [JsonPropertyName("url_2x")]
    public string? Url2X { get; init; }
    /// <summary>
    /// <para>A URL to the large version (112px x 112px) of the emote.</para>
    /// </summary>
    [JsonPropertyName("url_4x")]
    public string? Url4X { get; init; }
}