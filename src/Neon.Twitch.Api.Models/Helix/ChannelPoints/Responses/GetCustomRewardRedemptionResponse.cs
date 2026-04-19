using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.ChannelPoints.Models;

namespace Neon.Twitch.Api.Models.Helix.ChannelPoints.Responses;

public class GetCustomRewardRedemptionResponse
{
    /// <summary>
    /// <para>The list of redemptions for the specified reward. The list is empty if there are no redemptions that match the redemption criteria.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<CustomRewardRedemption>? Data { get; init; }
}