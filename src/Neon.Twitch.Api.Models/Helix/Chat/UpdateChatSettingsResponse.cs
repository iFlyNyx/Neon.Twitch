using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat;

public class UpdateChatSettingsResponse
{
    /// <summary>
    /// <para>The list of chat settings. The list contains a single object with all the settings.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ChatSettings>? Data { get; set; }
}