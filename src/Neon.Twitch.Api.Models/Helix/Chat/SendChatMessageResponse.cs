using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat;

public class SendChatMessageResponse
{
    /// <summary>
    /// <para>Details about a sent chat message</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<SentChatMessage>? Data { get; init; }
}