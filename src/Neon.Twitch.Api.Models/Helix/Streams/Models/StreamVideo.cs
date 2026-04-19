using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Streams.Models;

public class StreamVideo
{
    /// <summary>
    /// <para>An ID that identifies this video.</para>
    /// </summary>
    [JsonPropertyName("video_id")]
    public string? VideoId { get; init; }
    /// <summary>
    /// <para>The list of markers in this video. The list in ascending order by when the marker was created.</para>
    /// </summary>
    [JsonPropertyName("markers")]
    public List<Marker>? Markers { get; init; }
}