using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.EventSub;

public class GetEventSubSubscriptionsResponse
{
    /// <summary>
    /// <para>The list of subscriptions. The list is ordered by the oldest subscription first. The list is empty if the client hasn't created subscriptions or there are no subscriptions that match the specified filter criteria.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<EventSubSubscription>? Data { get; set; }
    /// <summary>
    /// <para>The total number of subscriptions you’ve created.</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }
    /// <summary>
    /// <para>The sum of all of your subscription costs. <see href="https://dev.twitch.tv/docs/eventsub/manage-subscriptions/#subscription-limits">Learn More</see></para>
    /// </summary>
    [JsonPropertyName("total_cost")]
    public int? TotalCost { get; set; }
    /// <summary>
    /// <para>The maximum total cost that you’re allowed to incur for all subscriptions you create.</para>
    /// </summary>
    [JsonPropertyName("max_total_cost")]
    public int? MaxTotalCost { get; set; }
    /// <summary>
    /// <para>An object that contains the cursor used to get the next page of subscriptions. The object is empty if there are no more pages to get. The number of subscriptions returned per page is undertermined.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; set; }
}