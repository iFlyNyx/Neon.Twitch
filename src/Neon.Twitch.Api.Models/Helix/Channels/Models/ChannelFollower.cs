using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Channels.Models;

public class ChannelFollower
{
    /// <summary>
    /// <para>The UTC timestamp when the user started following the broadcaster.</para>
    /// </summary>
    [JsonPropertyName("followed_at")]
    public string? FollowedAt { get; init; }
    /// <summary>
    /// <para>An ID that uniquely identifies the user that’s following the broadcaster.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>The user’s login name.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; init; }
    /// <summary>
    /// <para>The user’s display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; init; }
}