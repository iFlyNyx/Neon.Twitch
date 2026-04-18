using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users;

public class UserAuthorization
{
    /// <summary>
    /// <para>The user’s ID.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>The user’s display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; init; }
    /// <summary>
    /// <para>The user’s login name.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; init; }
    /// <summary>
    /// <para>An array of all the scopes the user has granted to the client ID.</para>
    /// </summary>
    [JsonPropertyName("scopes")]
    public List<string>? Scopes { get; init; }
}