using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Subscriptions;

public class Subscriber : UserSubscription
{
    /// <summary>
    /// <para>The name of the subscription.</para>
    /// </summary>
    [JsonPropertyName("plan_name")]
    public string? PlanName { get; init; }
    /// <summary>
    /// <para>An ID that identifies the subscribing user.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>The user’s display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; init; }
    /// <summary>
    /// <para>The user’s login name.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; init; }
}