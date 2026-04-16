using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Goals;

public class GetCreatorGoalsResponse
{
    /// <summary>
    /// <para>The list of goals. The list is empty if the broadcaster hasn’t created goals.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<CreatorGoal>? Data { get; set; }
}