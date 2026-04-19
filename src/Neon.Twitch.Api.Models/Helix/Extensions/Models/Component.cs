using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Models;

public class Component
{
    /// <summary>
    /// <para>The HTML file that is shown to viewers on the channel page when the extension is activated in a Video - Component slot.</para>
    /// </summary>
    [JsonPropertyName("viewer_url")]
    public string? ViewerUrl { get; init; }
    /// <summary>
    /// <para>The width value of the ratio (width : height) which determines the extension’s width, and how the extension’s iframe will resize in different video player environments.</para>
    /// </summary>
    [JsonPropertyName("aspect_ratio_x")]
    public int? AspectRatioX { get; init; }
    /// <summary>
    /// <para>The height value of the ratio (width : height) which determines the extension’s height, and how the extension’s iframe will resize in different video player environments.</para>
    /// </summary>
    [JsonPropertyName("aspect_ratio_y")]
    public int? AspectRatioY { get; init; }
    /// <summary>
    /// <para>A Boolean value that determines whether to apply CSS zoom. If true, a CSS zoom is applied such that the size of the extension is variable but the inner dimensions are fixed based on Scale Pixels. This allows your extension to render as if it is of fixed width and height. If false, the inner dimensions of the extension iframe are variable, meaning your extension must implement responsiveness.</para>
    /// </summary>
    [JsonPropertyName("autoscale")]
    public bool? Autoscale { get; init; }
    /// <summary>
    /// <para>The base width, in pixels, of the extension to use when scaling (see autoscale). This value is ignored if autoscale is false.</para>
    /// </summary>
    [JsonPropertyName("scale_pixels")]
    public int? ScalePixels { get; init; }
    /// <summary>
    /// <para>The height as a percent of the maximum height of a video component extension. Values are between 1% - 100%.</para>
    /// </summary>
    [JsonPropertyName("target_height")]
    public int? TargetHeight { get; init; }
    /// <summary>
    /// <para>A Boolean value that determines whether the extension can link to non-Twitch domains.</para>
    /// </summary>
    [JsonPropertyName("can_link_external_content")]
    public bool? CanLinkExternalContent { get; init; }
}