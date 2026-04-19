using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Channels.Models;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Channels.Responses;

public class GetChannelFollowersResponse
{
    /// <summary>
    /// <para>The list of users that follow the specified broadcaster. The list is in descending order by followed_at (with the most recent follower first). The list is empty if nobody follows the broadcaster, the specified user_id isn’t in the follower list, the user access token is missing the moderator:read:followers scope, or the user isn’t the broadcaster or moderator for the channel.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ChannelFollower>? Data { get; init; }
    /// <summary>
    /// <para>Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }
    /// <summary>
    /// <para>The total number of users that follow this broadcaster. As someone pages through the list, the number of users may change as users follow or unfollow the broadcaster.</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; init; }
}