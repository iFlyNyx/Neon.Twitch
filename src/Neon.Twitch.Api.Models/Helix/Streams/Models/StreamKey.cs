using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Streams.Models;

public class StreamKey
{
    /// <summary>
    /// <para>The channel’s stream key.</para>
    /// </summary>
    [JsonPropertyName("stream_key")]
    public string? Value { get; init; }
}