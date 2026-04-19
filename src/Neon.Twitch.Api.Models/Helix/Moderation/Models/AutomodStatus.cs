using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Models;

public class AutomodStatus
{
    /// <summary>
    /// <para>The caller-defined ID passed in the request.</para>
    /// </summary>
    [JsonPropertyName("msg_id")]
    public string? MessageId { get; init; }
    /// <summary>
    /// <para>A Boolean value that indicates whether Twitch would approve the message for chat or hold it for moderator review or block it from chat. Is true if Twitch would approve the message; otherwise, false if Twitch would hold the message for moderator review or block it from chat.</para>
    /// </summary>
    [JsonPropertyName("is_permitted")]
    public bool? IsPermitted { get; init; }
}