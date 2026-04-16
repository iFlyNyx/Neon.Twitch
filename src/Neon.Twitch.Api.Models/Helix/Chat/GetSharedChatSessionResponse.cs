using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat;

public class GetSharedChatSessionResponse
{
    /// <summary>
    /// <para>Details about a shared chat session, including the shared chat session owner and connected participants</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<SharedChatSession>? Data { get; set; }
}