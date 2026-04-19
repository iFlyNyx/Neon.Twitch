using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Moderation.Models;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Responses;

public class UpdateAutomodSettingsResponse
{
    /// <summary>
    /// <para>The list of AutoMod settings. The list contains a single object that contains all the AutoMod settings.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<AutomodSettings>? Data { get; init; }
}