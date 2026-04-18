using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Streams;

public class CreatedStreamMarkerResponse
{
    /// <summary>
    /// <para>A list that contains the single marker that you added.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<CreatedStreamMarker>? Data { get; set; }
}