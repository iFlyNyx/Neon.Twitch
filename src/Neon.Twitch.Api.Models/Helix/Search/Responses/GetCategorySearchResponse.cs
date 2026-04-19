using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Search.Models;

namespace Neon.Twitch.Api.Models.Helix.Search.Responses;

public class GetCategorySearchResponse
{
    /// <summary>
    /// <para>The list of games or categories that match the query. The list is empty if there are no matches.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<CategorySearch>? Data { get; init; }
}