using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Streams;

public class GetStreamKeyResponse
{
    /// <summary>
    /// <para>A list that contains the channel’s stream key.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<StreamKey>? Data { get; init; }
}