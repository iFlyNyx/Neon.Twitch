using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Streams.Models;

namespace Neon.Twitch.Api.Models.Helix.Streams.Responses;

public class GetStreamMarkersResponse
{
    /// <summary>
    /// <para>The list of markers grouped by the user that created the marks.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<StreamMarker>? Data { get; init; }
}