using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation;

public class BannedUser
{
    /// <summary>
    /// <para>The ID of the banned user.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }
    /// <summary>
    /// <para>The banned user’s login name.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; set; }
    /// <summary>
    /// <para>The banned user’s display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) of when the timeout expires, or an empty string if the user is permanently banned.</para>
    /// </summary>
    [JsonPropertyName("expires_at")]
    public string? ExpiresAt { get; set; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) of when the user was banned.</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }
    /// <summary>
    /// <para>The reason the user was banned or put in a timeout if the moderator provided one.</para>
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
    /// <summary>
    /// <para>The ID of the moderator that banned the user or put them in a timeout.</para>
    /// </summary>
    [JsonPropertyName("moderator_id")]
    public string? ModeratorId { get; set; }
    /// <summary>
    /// <para>The moderator’s login name.</para>
    /// </summary>
    [JsonPropertyName("moderator_login")]
    public string? ModeratorLogin { get; set; }
    /// <summary>
    /// <para>The moderator’s display name.</para>
    /// </summary>
    [JsonPropertyName("moderator_name")]
    public string? ModeratorName { get; set; }
}