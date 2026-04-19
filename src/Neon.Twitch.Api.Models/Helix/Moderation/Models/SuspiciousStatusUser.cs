using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Models;

public class SuspiciousStatusUser
{
    /// <summary>
    /// <para>The ID of the user being given the suspicious status.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>The user ID of the broadcaster indicating in which channel the status is being applied.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; init; }
    /// <summary>
    /// <para>The user ID of the moderator who applied the last status.</para>
    /// </summary>
    [JsonPropertyName("moderator_id")]
    public string? ModeratorId { get; init; }
    /// <summary>
    /// <para>The timestamp of the last time this user’s status was updated.</para>
    /// </summary>
    [JsonPropertyName("updated_at")]
    public string? UpdateAt { get; init; }
    /// <summary>
    /// <para>The type of suspicious status. Possible values are: ACTIVE_MONITORING, RESTRICTED</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; init; }
    /// <summary>
    /// <para>An array of strings representing the type(s) of suspicious user this is. Possible values are: MANUALLY_ADDED, DETECTED_BAN_EVADER, DETECTED_SUS_CHATTER, BANNED_IN_SHARED_CHANNEL</para>
    /// </summary>
    [JsonPropertyName("types")]
    public List<string>? Types { get; init; }
}