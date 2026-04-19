using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.ChannelPoints.Models;

namespace Neon.Twitch.Api.Models.Helix.ChannelPoints.Responses;

public class CreateCustomRewardsResponse
{
    /// <summary>
    /// <para>A list that contains the single custom reward you created.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<CustomReward>? Data { get; init; }
}