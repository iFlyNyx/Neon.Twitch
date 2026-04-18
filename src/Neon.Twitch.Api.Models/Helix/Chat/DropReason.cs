using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat;

public class DropReason
{
    /// <summary>
    /// <para>Code for why the message was dropped.</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; init; }
    /// <summary>
    /// <para>Message for why the message was dropped.</para>
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; init; }
}