using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Channels;

public class GetFollowedChannelsResponse
{
    /// <summary>
    /// <para>The list of broadcasters that the user follows. The list is in descending order by followed_at (with the most recently followed broadcaster first). The list is empty if the user doesn't follow anyone.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<FollowedChannel>? Data { get; set; }
    /// <summary>
    /// <para>Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through. </para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; set; }
    /// <summary>
    /// <para>The total number of broadcasters that the user follows. As someone pages through the list, the number may change as the user follows or unfollows broadcasters.</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }
}