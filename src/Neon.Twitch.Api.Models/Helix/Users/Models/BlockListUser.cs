using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users.Models;

public class BlockListUser
{
    /// <summary>
    /// <para>An ID that identifies the blocked user.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>The blocked user’s login name.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; init; }
    /// <summary>
    /// <para>The blocked user’s display name.</para>
    /// </summary>
    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }
}