using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Moderation.Enums;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Requests;

internal class ManageHeldAutomodMessageRequest
{
    /// <summary>
    /// <para>The moderator who is approving or denying the held message. This ID must match the user ID in the access token.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>The ID of the message to allow or deny.</para>
    /// </summary>
    [JsonPropertyName("msg_id")]
    public string? MessageId { get; init; }
    /// <summary>
    /// <para>The action to take for the message. Possible values are: ALLOW | DENY</para>
    /// </summary>
    [JsonPropertyName("action")]
    public AutomodAction? Action { get; init; }
}