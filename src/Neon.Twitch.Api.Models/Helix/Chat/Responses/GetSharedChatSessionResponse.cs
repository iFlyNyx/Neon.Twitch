using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Chat.Models;

namespace Neon.Twitch.Api.Models.Helix.Chat.Responses;

internal class GetSharedChatSessionResponse
{
    /// <summary>
    /// <para>Details about a shared chat session, including the shared chat session owner and connected participants</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<SharedChatSession>? Data { get; init; }
}