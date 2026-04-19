using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Goals.Models;

namespace Neon.Twitch.Api.Models.Helix.Goals.Responses;

public class GetCreatorGoalsResponse
{
    /// <summary>
    /// <para>The list of goals. The list is empty if the broadcaster hasn’t created goals.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<CreatorGoal>? Data { get; init; }
}