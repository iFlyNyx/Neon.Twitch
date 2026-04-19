using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Chat.Models;

namespace Neon.Twitch.Api.Models.Helix.Chat.Responses;

public class SendChatMessageResponse
{
    /// <summary>
    /// <para>Details about a sent chat message</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<SentChatMessage>? Data { get; init; }
}