using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Models;

internal class Mention
{
    /// <summary>
    /// <para>The mentioned user’s ID.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>The mentioned user’s login.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; init; }
    /// <summary>
    /// <para>The mentioned user’s display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; init; }
}