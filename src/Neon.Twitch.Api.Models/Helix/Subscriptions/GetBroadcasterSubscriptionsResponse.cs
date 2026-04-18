using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Subscriptions;

public class GetBroadcasterSubscriptionsResponse
{
    /// <summary>
    /// <para>The list of users that subscribe to the broadcaster. The list is empty if the broadcaster has no subscribers.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Subscriber>? Data { get; init; }
    /// <summary>
    /// <para>Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }
    /// <summary>
    /// <para>The current number of subscriber points earned by this broadcaster. Points are based on the subscription tier of each user that subscribes to this broadcaster. For example, a Tier 1 subscription is worth 1 point, Tier 2 is worth 2 points, and Tier 3 is worth 6 points. The number of points determines the number of emote slots that are unlocked for the broadcaster (see <see href="https://help.twitch.tv/s/article/subscriber-emote-guide#emoteslots">Subscriber Emote Slots</see>).</para>
    /// </summary>
    [JsonPropertyName("points")]
    public int? Points { get; init; }
    /// <summary>
    /// <para>The total number of users that subscribe to this broadcaster.</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; init; }
}