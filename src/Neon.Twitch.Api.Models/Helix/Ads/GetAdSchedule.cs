using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Ads;

public class GetAdSchedule
{
    /// <summary>
    /// <para>The number of snoozes available for the broadcaster.</para>
    /// </summary>
    [JsonPropertyName("snooze_count")]
    public int? SnoozeCount { get; init; }
    /// <summary>
    /// <para>The UTC timestamp when the broadcaster will gain an additional snooze, in RFC3339 format.</para>
    /// </summary>
    [JsonPropertyName("snooze_refresh_at")]
    public string? SnoozeRefreshAt { get; init; }
    /// <summary>
    /// <para>The UTC timestamp of the broadcaster’s next scheduled ad, in RFC3339 format. Empty if the channel has no ad scheduled or is not live.</para>
    /// </summary>
    [JsonPropertyName("next_ad_at")]
    public string? NextAdAt { get; init; }
    /// <summary>
    /// <para>The length in seconds of the scheduled upcoming ad break.</para>
    /// </summary>
    [JsonPropertyName("duration")]
    public int? Duration { get; init; }
    /// <summary>
    /// <para>The UTC timestamp of the broadcaster’s last ad-break, in RFC3339 format. Empty if the channel has not run an ad or is not live.</para>
    /// </summary>
    [JsonPropertyName("last_ad_at")]
    public string? LastAdAt { get; init; }
    /// <summary>
    /// <para>The amount of pre-roll free time remaining for the channel in seconds. Returns 0 if they are currently not pre-roll free.</para>
    /// </summary>
    [JsonPropertyName("preroll_free_time")]
    public int? PrerollFreeTime { get; init; }
}