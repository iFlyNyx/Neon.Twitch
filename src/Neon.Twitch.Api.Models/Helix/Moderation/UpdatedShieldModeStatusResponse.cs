using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation;

public class UpdatedShieldModeStatusResponse
{
    /// <summary>
    /// <para>A list that contains a single object with the broadcaster’s updated Shield Mode status.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ShieldModeStatus>? Data { get; init; }
}