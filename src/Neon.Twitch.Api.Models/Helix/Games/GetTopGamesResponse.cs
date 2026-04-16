using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Games;

public class GetTopGamesResponse
{
    /// <summary>
    /// <para>The list of broadcasts. The broadcasts are sorted by the number of viewers, with the most popular first.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Game>? Data { get; set; }
    /// <summary>
    /// <para>Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; set; }
}