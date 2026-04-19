using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Bits.Models;

namespace Neon.Twitch.Api.Models.Helix.Bits.Responses;

public class GetCheermotesResponse
{
    /// <summary>
    /// <para>The list of Cheermotes. The list is in ascending order by the order field’s value.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Cheermote>? Data { get; init; }
}