using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat;

public class Chatter
{
    /// <summary>
    /// <para>The ID of a user that’s connected to the broadcaster’s chat room.</para>
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