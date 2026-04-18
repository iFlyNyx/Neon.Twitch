using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Streams;

public class StreamMarker
{
    /// <summary>
    /// <para>The ID of the user that created the marker.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }
    /// <summary>
    /// <para>The user’s display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }
    /// <summary>
    /// <para>The user’s login name.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; set; }
    /// <summary>
    /// <para>A list of videos that contain markers. The list contains a single video.</para>
    /// </summary>
    [JsonPropertyName("videos")]
    public List<Video>? Videos { get; set; }
}