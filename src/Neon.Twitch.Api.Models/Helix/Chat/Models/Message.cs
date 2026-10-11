using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Models;

internal class Message
{
    /// <summary>
    /// <para>Plain text of the message.</para>
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; init; }
    /// <summary>
    /// <para>Ordered list of message fragments.</para>
    /// </summary>
    [JsonPropertyName("fragments")]
    public List<Fragment>? Fragments { get; init; }
}