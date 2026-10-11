using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Bits.Models;

namespace Neon.Twitch.Api.Models.Helix.Bits.Responses;

internal class GetCustomPowerUpResponse
{
    /// <summary>
    /// <para>A list of custom Power-ups. The list is in ascending order by id. If the broadcaster hasn’t created custom Power-ups, the list is empty.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<CustomPowerUp>? Data { get; init; }
}