using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Teams.Models;

namespace Neon.Twitch.Api.Models.Helix.Teams.Responses;

public class GetTeamsResponse
{
    /// <summary>
    /// <para>A list that contains the single team that you requested.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Team>? Data { get; init; }
}