using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Streams.Models;

namespace Neon.Twitch.Api.Models.Helix.Streams.Responses;

public class CreatedStreamMarkerResponse
{
    /// <summary>
    /// <para>A list that contains the single marker that you added.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<CreatedStreamMarker>? Data { get; init; }
}