using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.ChannelPoints.Models;

namespace Neon.Twitch.Api.Models.Helix.ChannelPoints.Responses;

public class GetCustomRewardsResponse
{
    /// <summary>
    /// <para>A list of custom rewards. The list is in ascending order by id. If the broadcaster hasn’t created custom rewards, the list is empty.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<CustomReward>? Data { get; init; }
}