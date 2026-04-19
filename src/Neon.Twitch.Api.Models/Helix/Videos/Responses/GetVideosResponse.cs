using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;
using Neon.Twitch.Api.Models.Helix.Videos.Models;

namespace Neon.Twitch.Api.Models.Helix.Videos.Responses;

public class GetVideosResponse
{
    /// <summary>
    /// <para>The list of published videos that match the filter criteria.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Video>? Data { get; init; }
    /// <summary>
    /// <para>Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }
}