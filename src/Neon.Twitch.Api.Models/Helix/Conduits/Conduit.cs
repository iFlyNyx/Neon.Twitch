using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Conduits;

public class Conduit
{
    /// <summary>
    /// <para>Conduit ID.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>Number of shards associated with this conduit.</para>
    /// </summary>
    [JsonPropertyName("shard_count")]
    public int? ShardCount { get; init; }
}