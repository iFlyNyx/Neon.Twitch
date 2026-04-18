using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Channels;

public class FollowedChannel
{
    /// <summary>
    /// <para>An ID that uniquely identifies the broadcaster that this user is following.</para>
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
    /// <para>The UTC timestamp when the user started following the broadcaster.</para>
    /// </summary>
    [JsonPropertyName("followed_at")]
    public string? FollowedAt { get; init; }
}