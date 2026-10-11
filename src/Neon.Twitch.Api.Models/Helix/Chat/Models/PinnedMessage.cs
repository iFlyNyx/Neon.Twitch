using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Models;

internal class PinnedMessage
{
    /// <summary>
    /// <para>The ID of the pinned chat message.</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; init; }
    /// <summary>
    /// <para>The ID of the broadcaster.</para> 
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; init; }
    /// <summary>
    /// <para>The ID of the user who sent the pinned message.</para>
    /// </summary>
    [JsonPropertyName("sender_user_id")]
    public string? SenderUserId { get; init; }
    /// <summary>
    /// <para>The login of the user who sent the pinned message.</para>
    /// </summary>
    [JsonPropertyName("sender_user_login")]
    public string? SenderUserLogin { get; init; }
    /// <summary>
    /// <para>The display name of the user who sent the pinned message.</para>
    /// </summary>
    [JsonPropertyName("sender_user_name")]
    public string? SenderUserName { get; init; }
    /// <summary>
    /// <para>The ID of the user who pinned the message.</para>
    /// </summary>
    [JsonPropertyName("pinned_by_user_id")]
    public string? PinnedByUserId { get; init; }
    /// <summary>
    /// <para>The login of the user who pinned the message.</para>
    /// </summary>
    [JsonPropertyName("pinned_by_user_login")]
    public string? PinnedByUserLogin { get; init; }
    /// <summary>
    /// <para>The display name of the user who pinned the message.</para>
    /// </summary>
    [JsonPropertyName("pinned_by_user_name")]
    public string? PinnedByUserName { get; init; }
    /// <summary>
    /// <para>The pinned message content.</para>
    /// </summary>
    [JsonPropertyName("message")]
    public Message? Message { get; init; }
    /// <summary>
    /// <para>RFC3339 timestamp of when the message was pinned.</para>
    /// </summary>
    [JsonPropertyName("starts_at")]
    public string? StartsAt { get; init; }
    /// <summary>
    /// <para>RFC3339 expiry timestamp. Null if pinned until stream ends.</para>
    /// </summary>
    [JsonPropertyName("ends_at")]
    public string? EndsAt { get; init; }
    /// <summary>
    /// <para>RFC3339 timestamp of last update.</para>
    /// </summary>
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }
}