using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation;

public class GetAutomodSettingsResponse
{
    /// <summary>
    /// <para>The list of AutoMod settings. The list contains a single object that contains all the AutoMod settings.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<AutomodSettings>? Data { get; set; }
}