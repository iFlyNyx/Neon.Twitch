using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Requests;

public class SendChatMessageRequest
{
    /// <summary>
    /// <para>The ID of the broadcaster whose chat room the message will be sent to.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    [Required]
    public string? BroadcasterId { get; set; }
    /// <summary>
    /// <para>The ID of the user sending the message. This ID must match the user ID in the user access token.</para>
    /// </summary>
    [JsonPropertyName("sender_id")]
    [Required]
    public string? SenderId { get; set; }
    /// <summary>
    /// <para>The message to send. The message is limited to a maximum of 500 characters. Chat messages can also include emoticons. To include emoticons, use the name of the emote. The names are case sensitive. Don’t include colons around the name (e.g., :bleedPurple:). If Twitch recognizes the name, Twitch converts the name to the emote before writing the chat message to the chat room</para>
    /// </summary>
    [JsonPropertyName("message")]
    [MaxLength(500)]
    [Required]
    public string? Message { get; set; }
    /// <summary>
    /// <para>The ID of the chat message being replied to.</para>
    /// </summary>
    [JsonPropertyName("reply_parent_message_id")]
    public string? ReplyParentMessageId { get; set; }
    /// <summary>
    /// <para>NOTE: This parameter can only be set when utilizing an App Access Token. It cannot be specified when a User Access Token is used, and will instead result in an HTTP 400 error.</para>
    /// <para>Determines if the chat message is sent only to the source channel (defined by broadcaster_id) during a shared chat session. This has no effect if the message is not sent during a shared chat session.</para>
    /// <para>If this parameter is not set, the default value when using an App Access Token is false. On May 19, 2025 the default value for this parameter will be updated to true, and chat messages sent using an App Access Token will only be shared with the source channel by default. If you prefer to send a chat message to both channels in a shared chat session, make sure this parameter is explicitly set to false in your API request before May 19.</para>
    /// </summary>
    [JsonPropertyName("for_source_only")]
    public bool? ForSourceOnly { get; set; }
}