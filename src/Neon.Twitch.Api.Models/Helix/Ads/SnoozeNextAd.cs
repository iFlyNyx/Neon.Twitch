using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Ads;

public class SnoozeNextAd
{
    /// <summary>
    /// <para>The number of snoozes available for the broadcaster.</para>
    /// </summary>
    [JsonPropertyName("snooze_count")]
    public int? SnoozeCount { get; set; }
    /// <summary>
    /// <para>The UTC timestamp when the broadcaster will gain an additional snooze, in RFC3339 format.</para>
    /// </summary>
    [JsonPropertyName("snooze_refresh_at")]
    public string? SnoozeRefreshAt { get; set; }
    /// <summary>
    /// <para>The UTC timestamp of the broadcaster’s next scheduled ad, in RFC3339 format.</para>
    /// </summary>
    [JsonPropertyName("next_ad_at")]
    public string? NextAdAt { get; set; }
}