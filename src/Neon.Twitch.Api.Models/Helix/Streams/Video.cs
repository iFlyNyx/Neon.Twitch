using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Streams;

public class Video
{
    /// <summary>
    /// <para>An ID that identifies this video.</para>
    /// </summary>
    [JsonPropertyName("video_id")]
    public string? VideoId { get; set; }
    /// <summary>
    /// <para>The list of markers in this video. The list in ascending order by when the marker was created.</para>
    /// </summary>
    [JsonPropertyName("markers")]
    public List<Marker>? Markers { get; set; }
}