using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.ChannelPoints.Requests;

public class PatchCustomRewardRequest : CustomRewardRequest
{
    /// <summary>
    /// <para>A Boolean value that determines whether to pause the reward. Set to true to pause the reward. Viewers can’t redeem paused rewards..</para>
    /// </summary>
    [JsonPropertyName("is_paused")]
    public bool? IsPaused { get; set; }
}