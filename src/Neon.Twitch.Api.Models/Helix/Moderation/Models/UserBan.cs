using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Models;

public class UserBan
{
    /// <summary>
    /// <para>The broadcaster whose chat room the user was banned from chatting in.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; init; }
    /// <summary>
    /// <para>The moderator that banned or put the user in the timeout.</para>
    /// </summary>
    [JsonPropertyName("moderator_id")]
    public string? ModeratorId { get; init; }
    /// <summary>
    /// <para>The user that was banned or put in a timeout.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) that the ban or timeout was placed.</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) that the timeout will end. Is null if the user was banned instead of being put in a timeout.</para>
    /// </summary>
    [JsonPropertyName("end_time")]
    public string? EndTime { get; init; }
}