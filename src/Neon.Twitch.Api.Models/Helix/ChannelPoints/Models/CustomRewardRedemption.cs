using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.ChannelPoints.Models;

public class CustomRewardRedemption
{
    /// <summary>
    /// <para>The ID that uniquely identifies the broadcaster.</para>
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
    /// <para>The ID that uniquely identifies this redemption.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The user’s login name.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; init; }
    /// <summary>
    /// <para>The ID that uniquely identifies the user that redeemed the reward.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>The user’s display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; init; }
    /// <summary>
    /// <para>The text the user entered at the prompt when they redeemed the reward; otherwise, an empty string if user input was not required.</para>
    /// </summary>
    [JsonPropertyName("user_input")]
    public string? UserInput { get; init; }
    /// <summary>
    /// <para>The state of the redemption. Possible values are:</para>
    /// <para>CANCELED|FULFILLED|UNFULFILLED</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; init; }
    /// <summary>
    /// <para>The date and time of when the reward was redeemed, in RFC3339 format.</para>
    /// </summary>
    [JsonPropertyName("redeemed_at")]
    public string? RedeemedAt { get; init; }
    /// <summary>
    /// <para>The reward that the user redeemed.</para>
    /// </summary>
    [JsonPropertyName("reward")]
    public Reward? Reward { get; init; }
}