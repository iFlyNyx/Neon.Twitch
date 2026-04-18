using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Clips;

public class GetClipsResponse
{
    /// <summary>
    /// <para>The list of video clips. For clips returned by game_id or broadcaster_id, the list is in descending order by view count. For lists returned by id, the list is in the same order as the input IDs.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Clip>? Data { get; init; }
    /// <summary>
    /// <para>The information used to page through the list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }
}