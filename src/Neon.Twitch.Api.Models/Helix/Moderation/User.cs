using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation;

public class User
{
    /// <summary>
    /// <para>The ID of the user that has permission to moderate the broadcaster’s channel.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    private string? UserId { get; set; }
    /// <summary>
    /// <para>The user’s login name.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; set; }
    /// <summary>
    /// <para>The user’s display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }
}