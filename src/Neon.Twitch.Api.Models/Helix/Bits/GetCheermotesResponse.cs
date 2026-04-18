using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Bits;

public class GetCheermotesResponse
{
    /// <summary>
    /// <para>The list of Cheermotes. The list is in ascending order by the order field’s value.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Cheermote>? Data { get; init; }
}