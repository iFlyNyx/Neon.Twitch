using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Models;

public class ExtensionView
{
    /// <summary>
    /// <para>Describes how the extension is displayed on mobile devices.</para>
    /// </summary>
    [JsonPropertyName("mobile")]
    public Mobile? Mobile { get; init; }
    /// <summary>
    /// <para>Describes how the extension is rendered if the extension may be activated as a panel extension.</para>
    /// </summary>
    [JsonPropertyName("panel")]
    public Panel? Panel { get; init; }
    /// <summary>
    /// <para>Describes how the extension is rendered if the extension may be activated as a video-overlay extension.</para>
    /// </summary>
    [JsonPropertyName("video_overlay")]
    public VideoOverlay? VideoOverlay { get; init; }
    /// <summary>
    /// <para>Describes how the extension is rendered if the extension may be activated as a video-component extension.</para>
    /// </summary>
    [JsonPropertyName("component")]
    public Component? Component { get; init; }
    /// <summary>
    /// <para>Describes the view that is shown to broadcasters while they are configuring your extension within the Extension Manager.</para>
    /// </summary>
    [JsonPropertyName("config")]
    public Config? Config { get; init; }
}