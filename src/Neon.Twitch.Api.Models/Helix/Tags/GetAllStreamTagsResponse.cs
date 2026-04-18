using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Tags;

public class GetAllStreamTagsResponse
{
    /// <summary>
    /// <para>The list of stream tags that the broadcaster can apply to their channel.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<StreamTag>? Data { get; set; }
    /// <summary>
    /// <para>The information used to page through the list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; set; }
}