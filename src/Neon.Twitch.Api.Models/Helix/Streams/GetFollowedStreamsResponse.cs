using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Streams;

public class GetFollowedStreamsResponse
{
    /// <summary>
    /// <para>The list of live streams of broadcasters that the specified user follows. The list is in descending order by the number of viewers watching the stream. Because viewers come and go during a stream, it’s possible to find duplicate or missing streams in the list as you page through the results. The list is empty if none of the followed broadcasters are streaming live.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Stream>? Data { get; init; }
    /// <summary>
    /// <para>The information used to page through the list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }
}