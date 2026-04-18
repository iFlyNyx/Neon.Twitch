using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Teams;

public class TeamUser
{
    /// <summary>
    /// <para>An ID that identifies the team member.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }
    /// <summary>
    /// <para>The team member’s login name.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; set; }
    /// <summary>
    /// <para>The team member’s display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }
}