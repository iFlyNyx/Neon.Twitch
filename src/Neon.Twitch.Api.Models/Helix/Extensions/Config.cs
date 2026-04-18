using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions;

public class Config
{
    /// <summary>
    /// <para>The HTML file shown to broadcasters while they are configuring your extension within the Extension Manager.</para>
    /// </summary>
    [JsonPropertyName("viewer_url")]
    public string? ViewerUrl { get; init; }
    /// <summary>
    /// <para>A Boolean value that determines whether the extension can link to non-Twitch domains.</para>
    /// </summary>
    [JsonPropertyName("can_link_external_content")]
    public bool? CanLinkExternalContent { get; init; }
}