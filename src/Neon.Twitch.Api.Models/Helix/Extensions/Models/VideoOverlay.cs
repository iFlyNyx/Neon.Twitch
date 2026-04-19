using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Models;

public class VideoOverlay
{
    /// <summary>
    /// <para>The HTML file that is shown to viewers on the channel page when the extension is activated on the Video - Overlay slot.</para>
    /// </summary>
    [JsonPropertyName("viewer_url")]
    public string? ViewerUrl { get; init; }
    /// <summary>
    /// <para>A Boolean value that determines whether the extension can link to non-Twitch domains.</para>
    /// </summary>
    [JsonPropertyName("can_link_external_content")]
    public bool? CanLinkExternalContent { get; init; }
}