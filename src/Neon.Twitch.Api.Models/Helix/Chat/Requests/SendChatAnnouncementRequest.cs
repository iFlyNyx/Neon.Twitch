using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Requests;

public class SendChatAnnouncementRequest
{
    /// <summary>
    /// <para>The announcement to make in the broadcaster’s chat room. Announcements are limited to a maximum of 500 characters; announcements longer than 500 characters are truncated.</para>
    /// </summary>
    [JsonPropertyName("message")]
    [MaxLength(500)]
    [Required]
    public string? Message { get; set; }
    /// <summary>
    /// <para>The color used to highlight the announcement. Possible case-sensitive values are:</para>
    /// <para>blue | green | orange | purple | primary (default)</para>
    /// <para>If color is set to primary or is not set, the channel’s accent color is used to highlight the announcement (see Profile Accent Color under <see href="https://www.twitch.tv/settings/profile">profile settings</see>, Channel and Videos, and Brand).</para>
    /// </summary>
    [JsonPropertyName("color")]
    public string? Color { get; set; }
    /// <summary>
    /// <para>NOTE: This parameter can only be set when utilizing an App Access Token. It cannot be specified when a User Access Token is used, and will instead result in an HTTP 400 error.</para>
    /// <para>Determines if the chat announcement is sent only to the source channel (defined by broadcaster_id) during a shared chat session. This has no effect if the announcement is not sent during a shared chat session.</para>
    /// <para>The default value when using an App Access Token is true. If you prefer to send an announcement to all channels in a shared chat session, set this parameter to false.</para>
    /// </summary>
    [JsonPropertyName("for_source_only")]
    public bool? ForSourceOnly { get; set; }
}