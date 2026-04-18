using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation;

public class ShieldModeStatus
{
    /// <summary>
    /// <para>A Boolean value that determines whether Shield Mode is active. Is true if Shield Mode is active; otherwise, false.</para>
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool? IsActive { get; set; }
    /// <summary>
    /// <para>An ID that identifies the moderator that last activated Shield Mode.</para>
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
    /// <summary>
    /// <para>The UTC timestamp (in RFC3339 format) of when Shield Mode was last activated.</para>
    /// </summary>
    [JsonPropertyName("last_activated_at")]
    public string? LastActivatedAt { get; set; }
}