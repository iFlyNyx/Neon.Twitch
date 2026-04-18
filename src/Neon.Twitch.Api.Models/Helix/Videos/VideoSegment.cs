using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Videos;

public class VideoSegment
{
    /// <summary>
    /// <para>The duration of the muted segment, in seconds.</para>
    /// </summary>
    [JsonPropertyName("duration")]
    public int? Duration { get; set; }
    /// <summary>
    /// <para>The offset, in seconds, from the beginning of the video to where the muted segment begins.</para>
    /// </summary>
    [JsonPropertyName("offset")]
    public int? Offset { get; set; }
}