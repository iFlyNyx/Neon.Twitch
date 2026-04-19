using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Ads.Models;

public class GetAdSchedule : AdDetail
{
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