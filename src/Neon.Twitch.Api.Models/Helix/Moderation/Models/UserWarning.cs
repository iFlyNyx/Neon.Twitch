using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Models;

public class UserWarning
{
    /// <summary>
    /// <para>The ID of the channel in which the warning will take effect.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; init; }
    /// <summary>
    /// <para>The ID of the warned user.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>The ID of the user who applied the warning.</para>
    /// </summary>
    [JsonPropertyName("moderator_id")]
    public string? ModeratorId { get; init; }
    /// <summary>
    /// <para>The reason provided for warning.</para>
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }
}