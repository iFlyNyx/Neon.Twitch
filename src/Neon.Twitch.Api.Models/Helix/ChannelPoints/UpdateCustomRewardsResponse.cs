using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.ChannelPoints;

public class UpdateCustomRewardsResponse
{
    /// <summary>
    /// <para>The list contains the single reward that you updated.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<CustomReward>? Data { get; set; }
}