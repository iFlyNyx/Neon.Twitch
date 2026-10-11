using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Chat.Models;

namespace Neon.Twitch.Api.Models.Helix.Chat.Responses;

internal class GetPinnedChatMessage
{
    /// <summary>
    /// <para>Pinned messages. Empty if none pinned.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<PinnedMessage>? Data { get; init; }
}