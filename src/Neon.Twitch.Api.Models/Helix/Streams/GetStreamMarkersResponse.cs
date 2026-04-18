using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Streams;

public class GetStreamMarkersResponse
{
    /// <summary>
    /// <para>The list of markers grouped by the user that created the marks.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<StreamMarker>? Data { get; init; }
}