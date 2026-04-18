using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Schedule;

public class Segment
{
    /// <summary>
    /// <para>An ID that identifies this broadcast segment.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) of when the broadcast starts.</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) of when the broadcast ends.</para>
    /// </summary>
    [JsonPropertyName("end_time")]
    public string? EndTime { get; set; }
    /// <summary>
    /// <para>The broadcast segment’s title.</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    /// <summary>
    /// <para>Indicates whether the broadcaster canceled this segment of a recurring broadcast. If the broadcaster canceled this segment, this field is set to the same value that’s in the end_time field; otherwise, it’s set to null.</para>
    /// </summary>
    [JsonPropertyName("canceled_until")]
    public string? CanceledUntil { get; set; }
    /// <summary>
    /// <para>The type of content that the broadcaster plans to stream or null if not specified.</para>
    /// </summary>
    [JsonPropertyName("category")]
    public Category? Category { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether the broadcast is part of a recurring series that streams at the same time each week or is a one-time broadcast. Is true if the broadcast is part of a recurring series.</para>
    /// </summary>
    [JsonPropertyName("is_recurring")]
    public bool? IsRecurring  { get; set; }
}