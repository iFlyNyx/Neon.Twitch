using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Chat.Models;

namespace Neon.Twitch.Api.Models.Helix.Chat.Responses;

public class GetChatSettingsResponse
{
    /// <summary>
    /// <para>The list of chat settings. The list contains a single object with all the settings.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ChatSettings>? Data { get; init; }
}