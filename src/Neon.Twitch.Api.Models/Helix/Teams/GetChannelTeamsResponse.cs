using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Teams;

public class GetChannelTeamsResponse
{
    /// <summary>
    /// <para>The list of teams that the broadcaster is a member of. Returns an empty array if the broadcaster is not a member of a team.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ChannelTeam>? Data { get; set; }
}