using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Clips.Models;

public class ClipDownload
{
    /// <summary>
    /// <para>An ID that uniquely identifies the clip.</para>
    /// </summary>
    [JsonPropertyName("clip_id")]
    public string? ClipId { get; init; }
    /// <summary>
    /// <para>The landscape URL to download the clip. This field is null if the URL is not available.</para>
    /// </summary>
    [JsonPropertyName("landscape_download_url")]
    public string? LandscapeDownloadUrl { get; init; }
    /// <summary>
    /// <para>The portrait URL to download the clip. This field is null if the URL is not available.</para>
    /// </summary>
    [JsonPropertyName("portrait_download_url")]
    public string? PortraitDownloadUrl { get; init; }
}