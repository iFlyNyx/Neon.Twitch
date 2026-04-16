using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat;

public class UserChatColor
{
    /// <summary>
    /// <para>An ID that uniquely identifies the user.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }
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
    /// <summary>
    /// <para>The Hex color code that the user uses in chat for their name. If the user hasn’t specified a color in their settings, the string is empty.</para>
    /// </summary>
    [JsonPropertyName("color")]
    public string? Color { get; set; }
}