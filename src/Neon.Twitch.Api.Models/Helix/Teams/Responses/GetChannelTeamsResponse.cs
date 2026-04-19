using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Teams.Models;

namespace Neon.Twitch.Api.Models.Helix.Teams.Responses;

public class GetChannelTeamsResponse
{
    /// <summary>
    /// <para>The list of teams that the broadcaster is a member of. Returns an empty array if the broadcaster is not a member of a team.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ChannelTeam>? Data { get; init; }
}