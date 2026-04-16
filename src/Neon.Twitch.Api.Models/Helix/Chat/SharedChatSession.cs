using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat;

public class SharedChatSession
{
    /// <summary>
    /// <para>The unique identifier for the shared chat session.</para>
    /// </summary>
    [JsonPropertyName("session_id")]
    public string? SessionId { get; set; }
    /// <summary>
    /// <para>The User ID of the host channel.</para>
    /// </summary>
    [JsonPropertyName("host_broadcaster_id")]
    public string? HostBroadcasterId { get; set; }
    /// <summary>
    /// <para>The list of participants in the session.</para>
    /// </summary>
    [JsonPropertyName("participants")]
    public List<Participant>? Participants { get; set; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) for when the session was created.</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) for when the session was last updated.</para>
    /// </summary>
    [JsonPropertyName("updated_at")]
    public string? UpdateAt { get; set; }
}