using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Streams;

public class CreatedStreamMarker
{
    /// <summary>
    /// <para>An ID that identifies this marker.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) of when the user created the marker.</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }
    /// <summary>
    /// <para>The relative offset (in seconds) of the marker from the beginning of the stream.</para>
    /// </summary>
    [JsonPropertyName("position_seconds")]
    public int? PositionSeconds { get; set; }
    /// <summary>
    /// <para>A description that the user gave the marker to help them remember why they marked the location.</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}