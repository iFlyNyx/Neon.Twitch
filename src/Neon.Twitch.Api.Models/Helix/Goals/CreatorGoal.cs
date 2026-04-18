using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Goals;

public class CreatorGoal
{
    /// <summary>
    /// <para>An ID that identifies this goal.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>An ID that identifies the broadcaster that created the goal.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; init; }
    /// <summary>
    /// <para>The broadcaster’s display name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string? BroadcasterName { get; init; }
    /// <summary>
    /// <para>The broadcaster’s login name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string? BroadcasterLogin { get; init; }
    /// <summary>
    /// <para>The type of goal. Possible values are: </para>
    /// <para>follower — The goal is to increase followers.</para>
    /// <para>subscription — The goal is to increase subscriptions. This type shows the net increase or decrease in tier points associated with the subscriptions.</para>
    /// <para>subscription_count — The goal is to increase subscriptions. This type shows the net increase or decrease in the number of subscriptions.</para>
    /// <para>new_subscription — The goal is to increase subscriptions. This type shows only the net increase in tier points associated with the subscriptions (it does not account for users that unsubscribed since the goal started).</para>
    /// <para>new_subscription_count — The goal is to increase subscriptions. This type shows only the net increase in the number of subscriptions (it does not account for users that unsubscribed since the goal started).</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; init; }
    /// <summary>
    /// <para>A description of the goal. Is an empty string if not specified.</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }
    /// <summary>
    /// <para>The goal’s current value. The goal’s type determines how this value is increased or decreased. </para>
    /// <para>If type is follower, this field is set to the broadcaster's current number of followers. This number increases with new followers and decreases when users unfollow the broadcaster.</para>
    /// <para>If type is subscription, this field is increased and decreased by the points value associated with the subscription tier. For example, if a tier-two subscription is worth 2 points, this field is increased or decreased by 2, not 1.</para>
    /// <para>If type is subscription_count, this field is increased by 1 for each new subscription and decreased by 1 for each user that unsubscribes.</para>
    /// <para>If type is new_subscription, this field is increased by the points value associated with the subscription tier. For example, if a tier-two subscription is worth 2 points, this field is increased by 2, not 1.</para>
    /// <para>If type is new_subscription_count, this field is increased by 1 for each new subscription.</para>
    /// </summary>
    [JsonPropertyName("current_amount")]
    public int? CurrentAmount { get; init; }
    /// <summary>
    /// <para>The goal’s target value. For example, if the broadcaster has 200 followers before creating the goal, and their goal is to double that number, this field is set to 400.</para>
    /// </summary>
    [JsonPropertyName("target_amount")]
    public int? TargetAmount { get; init; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) that the broadcaster created the goal.</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }
}