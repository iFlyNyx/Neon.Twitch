using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Teams.Models;

public class TeamUser
{
    /// <summary>
    /// <para>An ID that identifies the team member.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>The team member’s login name.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; init; }
    /// <summary>
    /// <para>The team member’s display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; init; }
}