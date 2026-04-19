using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;
using Neon.Twitch.Api.Models.Helix.Tags.Models;

namespace Neon.Twitch.Api.Models.Helix.Tags.Responses;

public class GetAllStreamTagsResponse
{
    /// <summary>
    /// <para>The list of stream tags that the broadcaster can apply to their channel.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<StreamTag>? Data { get; init; }
    /// <summary>
    /// <para>The information used to page through the list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }
}