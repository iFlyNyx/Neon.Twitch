using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Moderation.Models;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Responses;

public class UpdatedShieldModeStatusResponse
{
    /// <summary>
    /// <para>A list that contains a single object with the broadcaster’s updated Shield Mode status.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ShieldModeStatus>? Data { get; init; }
}