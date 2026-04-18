using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Search;

public class GetCategorySearchResponse
{
    /// <summary>
    /// <para>The list of games or categories that match the query. The list is empty if there are no matches.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<CategorySearch>? Data { get; init; }
}