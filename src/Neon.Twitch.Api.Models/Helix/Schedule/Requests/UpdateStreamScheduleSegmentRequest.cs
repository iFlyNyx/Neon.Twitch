using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Schedule.Requests;

public class UpdateStreamScheduleSegmentRequest
{
    /// <summary>
    /// <para>The date and time that the broadcast segment starts. Specify the date and time in RFC3339 format (for example, 2022-08-02T06:00:00Z).</para>
    /// <para>NOTE: Only partners and affiliates may update a broadcast’s start time and only for non-recurring segments.</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }
    /// <summary>
    /// <para>The length of time, in minutes, that the broadcast is scheduled to run. The duration must be in the range 30 through 1380 (23 hours).</para>
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
    /// <summary>
    /// <para>The ID of the category that best represents the broadcast’s content. To get the category ID, use the <see href="https://dev.twitch.tv/docs/api/reference/#search-categories">Search Categories</see> endpoint.</para>
    /// </summary>
    [JsonPropertyName("category_id")]
    public string? CategoryId { get; set; }
    /// <summary>
    /// <para>The broadcast’s title. The title may contain a maximum of 140 characters.</para>
    /// </summary>
    [JsonPropertyName("title")]
    [MaxLength(140)]
    public string? Title { get; set; }
    /// <summary>
    /// <para>A Boolean value that indicates whether the broadcast is canceled. Set to true to cancel the segment.</para>
    /// <para>NOTE: For recurring segments, the API cancels the first segment after the current UTC date and time and not the specified segment (unless the specified segment is the next segment after the current UTC date and time).</para>
    /// </summary>
    [JsonPropertyName("is_canceled")]
    public bool? IsCanceled { get; set; }
    /// <summary>
    /// <para>The time zone where the broadcast takes place. Specify the time zone using <see href="https://www.iana.org/time-zones">IANA time zone database</see> format (for example, America/New_York).</para>
    /// </summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}