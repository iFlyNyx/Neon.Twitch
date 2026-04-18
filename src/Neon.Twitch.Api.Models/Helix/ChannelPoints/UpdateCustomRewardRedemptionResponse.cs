using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.ChannelPoints;

public class UpdateCustomRewardRedemptionResponse
{
    /// <summary>
    /// <para>The list contains the single redemption that you updated.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<CustomRewardRedemption>? Data { get; init; }
}