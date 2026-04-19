using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Subscriptions.Models;

public class UserSubscription
{
    /// <summary>
    /// <para>An ID that identifies the broadcaster.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; init; }
    /// <summary>
    /// <para>The broadcaster’s login name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string? BroadcasterLogin { get; init; }
    /// <summary>
    /// <para>The broadcaster’s display name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string? BroadcasterName { get; init; }
    /// <summary>
    /// <para>The ID of the user that gifted the subscription to the user. Is an empty string if is_gift is false.</para>
    /// </summary>
    [JsonPropertyName("gifter_id")]
    public string? GifterId { get; init; }
    /// <summary>
    /// <para>The gifter’s login name. Is an empty string if is_gift is false.</para>
    /// </summary>
    [JsonPropertyName("gifter_login")]
    public string? GifterLogin { get; init; }
    /// <summary>
    /// <para>The gifter’s display name. Is an empty string if is_gift is false.</para>
    /// </summary>
    [JsonPropertyName("gifter_name")]
    public string? GifterName { get; init; }
    /// <summary>
    /// <para>A Boolean value that determines whether the subscription is a gift subscription. Is true if the subscription was gifted.</para>
    /// </summary>
    [JsonPropertyName("is_gift")]
    public bool? IsGift { get; init; }
    /// <summary>
    /// <para>The type of subscription. Possible values are:</para>
    /// <para>1000 (tier 1) | 2000 (tier 2) | 3000 (tier 3)</para>
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; init; }
}