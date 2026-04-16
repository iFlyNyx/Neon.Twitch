using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Games;

public class GetGamesResponse
{
    /// <summary>
    /// <para>The list of categories and games. The list is empty if the specified categories and games weren’t found.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Game>? Data { get; set; }
}