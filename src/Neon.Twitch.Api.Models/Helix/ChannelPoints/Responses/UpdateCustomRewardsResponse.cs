using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.ChannelPoints.Models;

namespace Neon.Twitch.Api.Models.Helix.ChannelPoints.Responses;

public class UpdateCustomRewardsResponse
{
    /// <summary>
    /// <para>The list contains the single reward that you updated.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<CustomReward>? Data { get; init; }
}