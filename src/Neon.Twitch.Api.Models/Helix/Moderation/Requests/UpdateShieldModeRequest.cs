using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Requests;

public class UpdateShieldModeRequest
{
    /// <summary>
    /// <para>A Boolean value that determines whether to activate Shield Mode. Set to true to activate Shield Mode; otherwise, false to deactivate Shield Mode.</para>
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool? IsActive { get; set; }
}