using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Models;

public class SentChatMessage
{
    /// <summary>
    /// <para>The message id for the message that was sent.</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; init; }
    /// <summary>
    /// <para>If the message passed all checks and was sent.</para>
    /// </summary>
    [JsonPropertyName("is_sent")]
    public bool? IsSent { get; init; }
    /// <summary>
    /// <para>The reason the message was dropped, if any.</para>
    /// </summary>
    [JsonPropertyName("drop_reason")]
    public DropReason? DropReason { get; init; }
}