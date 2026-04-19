using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Ads.Models;

namespace Neon.Twitch.Api.Models.Helix.Ads.Responses;

public class SnoozeNextAdResponse
{
    /// <summary>
    /// <para>A list that contains information about the channel’s snoozes and next upcoming ad after successfully snoozing.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<SnoozeNextAd>? Data { get; init; }
}