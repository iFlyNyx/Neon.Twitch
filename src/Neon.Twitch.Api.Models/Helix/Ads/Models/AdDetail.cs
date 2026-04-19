using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Ads.Models;

public abstract class AdDetail
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
}