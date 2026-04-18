using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Teams;

public class Team
{
    /// <summary>
    /// <para>The list of team members.</para>
    /// </summary>
    [JsonPropertyName("users")]
    public List<TeamUser>? Users { get; set; }
    /// <summary>
    /// <para>A URL to the team’s background image.</para>
    /// </summary>
    [JsonPropertyName("background_image_url")]
    public string? BackgroundImageUrl { get; set; }
    /// <summary>
    /// <para>A URL to the team’s banner.</para>
    /// </summary>
    [JsonPropertyName("banner")]
    public string? Banner { get; set; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) of when the team was created.</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) of the last time the team was updated.</para>
    /// </summary>
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; set; }
    /// <summary>
    /// <para>The team’s description. The description may contain formatting such as Markdown, HTML, newline (\n) characters, etc.</para>
    /// </summary>
    [JsonPropertyName("info")]
    public string? Info { get; set; }
    /// <summary>
    /// <para>A URL to a thumbnail image of the team’s logo.</para>
    /// </summary>
    [JsonPropertyName("thumbnail_url")]
    public string? ThumbnailUrl { get; set; }
    /// <summary>
    /// <para>The team’s name.</para>
    /// </summary>
    [JsonPropertyName("team_name")]
    public string? TeamName { get; set; }
    /// <summary>
    /// <para>The team’s display name.</para>
    /// </summary>
    [JsonPropertyName("team_display_name")]
    public string? TeamDisplayName { get; set; }
    /// <summary>
    /// <para>An ID that identifies the team.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}