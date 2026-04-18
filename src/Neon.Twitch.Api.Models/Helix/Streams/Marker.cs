using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Streams;

public class Marker
{
    /// <summary>
    /// <para>An ID that identifies this marker.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) of when the user created the marker.</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }
    /// <summary>
    /// <para>The description that the user gave the marker to help them remember why they marked the location. Is an empty string if the user didn’t provide one.</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }
    /// <summary>
    /// <para>The relative offset (in seconds) of the marker from the beginning of the stream.</para>
    /// </summary>
    [JsonPropertyName("position_seconds")]
    public int? PositionSeconds { get; init; }
    /// <summary>
    /// <para>A URL that opens the video in Twitch Highlighter.</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; init; }
}