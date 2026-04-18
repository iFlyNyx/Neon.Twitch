using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Teams;

public class GetTeamsResponse
{
    /// <summary>
    /// <para>A list that contains the single team that you requested.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Team>? Data { get; init; }
}