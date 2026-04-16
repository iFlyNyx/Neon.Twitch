using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions;

public class Panel
{
    /// <summary>
    /// <para>The HTML file that is shown to viewers on the channel page when the extension is activated in a Panel slot.</para>
    /// </summary>
    [JsonPropertyName("viewer_url")]
    public string? ViewerUrl { get; set; }
    /// <summary>
    /// <para>The height, in pixels, of the panel component that the extension is rendered in.</para>
    /// </summary>
    [JsonPropertyName("height")]
    public int? Height { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether the extension can link to non-Twitch domains.</para>
    /// </summary>
    [JsonPropertyName("can_link_external_content")]
    public bool? CanLinkExternalContent { get; set; }
}