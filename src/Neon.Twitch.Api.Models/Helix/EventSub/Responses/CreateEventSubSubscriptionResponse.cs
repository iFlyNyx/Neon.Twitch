using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.EventSub.Models;

namespace Neon.Twitch.Api.Models.Helix.EventSub.Responses;

public class CreateEventSubSubscriptionResponse
{
    /// <summary>
    /// <para>A list that contains the single subscription that you created.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<EventSubSubscription>? Data { get; init; }
    /// <summary>
    /// <para>The total number of subscriptions you’ve created.</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; init; }
    /// <summary>
    /// <para>The sum of all of your subscription costs. <see href="https://dev.twitch.tv/docs/eventsub/manage-subscriptions/#subscription-limits">Learn More</see></para>
    /// </summary>
    [JsonPropertyName("total_cost")]
    public int? TotalCost { get; init; }
    /// <summary>
    /// <para>The maximum total cost that you’re allowed to incur for all subscriptions you create.</para>
    /// </summary>
    [JsonPropertyName("max_total_cost")]
    public int? MaxTotalCost { get; init; }
}